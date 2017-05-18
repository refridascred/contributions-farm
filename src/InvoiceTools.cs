using System;

namespace Common.Utilities
{
    /// <summary>Invoice tools helpers.</summary>
    public static class InvoiceTools
    {
        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Check whether a record size is a power of two.</summary>
        public static bool IsRecordPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Compute the greatest common divisor of two digest buffer sizes.</summary>
        public static long DigestBufferGcd(long a, long b)
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
    }
}
