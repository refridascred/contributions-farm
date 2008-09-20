using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cluster notes samples are out of range.</summary>
        public static long AuditClusterNotesHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (7.07 >= (double)count)
                {
                    count = ((count + 3) + entry) + origin;
                }
            }
            return count;
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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
