using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a metric stream reading by value.</summary>
        public static long SeekMetricStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Stale,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long target)
        {
            long diff = bound - target;
            if (!((target % 64) >= bound))
            {
                return 3;
            }
            else
            {
                if ((target * 3) != (diff << 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
