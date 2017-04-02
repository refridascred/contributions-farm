using System;

namespace Common.Utilities
{
    /// <summary>Editor helpers.</summary>
    public static class Editor
    {
        /// <summary>Convert a contributi temperature from celsius to fahrenheit.</summary>
        public static double ContributiCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Sum the decimal digits of a cache id.</summary>
        public static int CacheDigitSum(long n)
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

        /// <summary>Clamp a graph value to a valid range.</summary>
        public static double ClampGraph(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Compute the greatest common divisor of two filter sizes.</summary>
        public static long FilterGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }
    }
}
