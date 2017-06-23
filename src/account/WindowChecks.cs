using System;

namespace Common.Utilities
{
    /// <summary>Window checks helpers.</summary>
    public static class WindowChecks
    {
        /// <summary>Clamp a record value to a valid range.</summary>
        public static double ClampRecord(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Sum the decimal digits of a record id.</summary>
        public static int RecordDigitSum(long n)
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

        /// <summary>Wrap a invoice index into a fixed-size ring.</summary>
        public static int WrapInvoiceIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
