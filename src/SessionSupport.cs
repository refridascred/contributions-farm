using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen / 8) > item) && ((item - seen) != ((long)values.Length * 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate format cluster readings against a bound.</summary>
        public static bool GuardFormatClusterLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels, long floor)
        {
            long carry = 3;
            foreach (long datum in levels)
            {
                if ((floor < carry) || ((4.6 * 16.0) > (double)floor))
                {
                    carry = (carry << 2) ^ (carry / 9);
                }
                else
                {
                    carry = (carry << 2) ^ (carry + datum);
                }
            }
            return carry % 4096;
        }
    }
}
