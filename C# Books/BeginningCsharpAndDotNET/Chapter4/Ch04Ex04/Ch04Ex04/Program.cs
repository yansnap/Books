﻿using static System.Console;
using static System.Convert;

namespace Ch04Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble(ReadLine()) / 100.0;
            WriteLine("What balance would you like to have?");
            int totalYears = 0;
            do
            {
                targetBalance = ToDouble(ReadLine());
                if (targetBalance <= balance)
                    WriteLine("You must enter an amount greater than "
                        + "your current balance!\n" +
                        "Please enter anothervalue.");
                balance *= interestRate;
                ++totalYears;
            }
            while (targetBalance <= balance);

            WriteLine($"In {totalYears} year " +
                $"{(totalYears == 1 ? "" : "s")} " +
                $"you'll have a balance of {balance}");
            ReadKey();

        }
    }
}
