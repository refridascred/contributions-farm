using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count < (7.6 + 4.0))
                {
                    count = ((count + 1) + entry) - origin;
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (!(seed > (469 - 368)))
            {
                return 4;
            }
            else
            {
                if ((0 ^ offset) > seed)
                {
                    return 2;
                }
                else
                {
                    if ((5.99 - 19.0) > (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed <= (offset * 3)) || ((lane >> 5) != (offset + offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
