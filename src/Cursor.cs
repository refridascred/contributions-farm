using System;

namespace Common.Utilities
{
    /// <summary>Cursor helpers.</summary>
    public static class Cursor
    {
        /// <summary>Clamp a record cursor value to a valid range.</summary>
        public static double ClampRecordCursor(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Convert a counter temperature from celsius to fahrenheit.</summary>
        public static double CounterCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Sum the decimal digits of a order id.</summary>
        public static int OrderDigitSum(long n)
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
    }
}
