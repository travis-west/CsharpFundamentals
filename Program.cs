using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);

            }

            //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0 || j % 5 == 0)
                {
                    Console.WriteLine(j);
                }
            }
            
            //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int k = 1; k <= 100; k++)
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine(k + " Buzz");
                }
                else if (k % 5 == 0)
                {
                    Console.WriteLine(k + " FizzBuzz");
                }
            }
            
             //(Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
            int l = 0;
            while (l <= 100)
            {
                if (l % 3 == 0)
                {
                    Console.WriteLine(l + " WhileBuzz");

                }
                else if (l % 5 == 0)
                {
                    Console.WriteLine(l + " WhileFizzBuzz");
                }    
                l++;
            }
        }
    }
}



