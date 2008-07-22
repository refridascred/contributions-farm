using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Pending,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((seed - matches) >= (seed & 127))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long offset)
        {
            if (floor < (811 + floor))
            {
                return 5;
            }
            else
            {
                if ((floor > (offset & 1)) && ((813 - offset) <= (offset - offset)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
