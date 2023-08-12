﻿using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            void populate() {
                for (int i = 0; i < 50; i++) {
                    numbers[i] = new Random().Next() % 50;
                }
            }
            populate();

            //TODO: Print the first number of the array
            Console.WriteLine("first num:"+numbers[0]);

            //TODO: Print the last number of the array
            Console.WriteLine("last num: "+numbers[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            

            Console.WriteLine("-------------------");
            ThreeKiller(numbers);
            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> lst = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(lst.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(lst);

            //TODO: Print the new capacity
            Console.WriteLine(lst.Count);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string ins = Console.ReadLine();
            NumberCheckerS(lst, ins);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(lst);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(lst);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            lst.Sort();
            NumberPrinter(lst);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] arr2 = new int[50];
            for (int i = 0; i < 50; i++) arr2[i] = lst[i];
            Console.WriteLine("transferred into array: ");
            NumberPrinter(arr2);
            //TODO: Clear the list
            lst.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] % 3 == 0) numbers[i] = 0;
                Console.WriteLine(numbers[i]);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++) {
                if (numberList[i] % 2 == 1) numberList[i] = 0;
            }

            NumberPrinter(numberList);
        }

        //number checker wrapper to number checker
        private static void NumberCheckerS(List<int> numberList, string searchString) {
            try
            {
                int searchInt = int.Parse(searchString);
                NumberChecker(numberList, searchInt);
            }
            catch (Exception e) {
                Console.WriteLine("you entered an invalid number. Try again.");
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber)) Console.WriteLine("number found in list.");
            else Console.WriteLine("number not found in list.");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++) {
                numberList.Add(rng.Next() % 50);
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++) {
                int num = array[i];
                int num1 = array[49 - i];
                int tmp = num;
                array[i] = array[49 - i];
                array[49 - i] = tmp;
            }
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
