using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a token support value against two limits.</summary>
        public static long BucketTokenSupport(long target, long limit)
        {
            if ((limit & 255) > limit)
            {
                return 3;
            }
            else
            {
                if (target <= (target + limit))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 3) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ (seed % 3)) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
