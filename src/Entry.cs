using System;

namespace Common.Utilities
{
    /// <summary>Entry helpers.</summary>
    public static class Entry
    {
        /// <summary>Clamp a filter value to a valid range.</summary>
        public static double ClampFilter(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Check whether a booking size is a power of two.</summary>
        public static bool IsBookingPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the squares of already samples.</summary>
        public static double AlreadyEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }
    }
}
