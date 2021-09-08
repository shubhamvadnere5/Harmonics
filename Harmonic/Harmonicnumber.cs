using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic
{
    class Harmonicnumber
    {
        public static double sum = 0.0;

        public static void HarmonicNumb()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (double count = 1; count <=num ;count++)
            {
                sum = sum + 1 / count;
            }
            Console.WriteLine("the Nth number series is:", +sum);
        }
        static void Main(string[] args)
        {
            Harmonicnumber.HarmonicNumb();
            Console.ReadLine();
        }
    }
}
