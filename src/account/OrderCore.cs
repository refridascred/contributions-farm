using System;

namespace Common.Utilities
{
    /// <summary>Order core helpers.</summary>
    public static class OrderCore
    {
        /// <summary>Sum the decimal digits of a contributi id.</summary>
        public static int ContributiDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Convert a buffer temperature from celsius to fahrenheit.</summary>
        public static double BufferCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
