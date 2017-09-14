using System;

namespace Common.Utilities
{
    /// <summary>Context utils helpers.</summary>
    public static class ContextUtils
    {
        /// <summary>Clamp a batches value to a valid range.</summary>
        public static double ClampBatches(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Convert a schema window temperature from celsius to fahrenheit.</summary>
        public static double SchemaWindowCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Calculate a 16-bit checksum of a booking key.</summary>
        public static int BookingChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Sum the decimal digits of a window command id.</summary>
        public static int WindowCommandDigitSum(long n)
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
