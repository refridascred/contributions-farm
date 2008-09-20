using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Done,
            Pending,
        }

        /// <summary>Validate graph cache readings against a bound.</summary>
        public static bool GuardGraphCacheLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long total = 8;
            foreach (long item in readings)
            {
                if (!((double)item >= (double)total))
                {
                    total = total + total;
                }
                if (item <= (271 & 255))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
