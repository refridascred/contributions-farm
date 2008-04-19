using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long offset)
        {
            long next = floor ^ offset;
            if (((double)floor < (2.4 * 15.0)) || (floor > (80 - next)))
            {
                return 7;
            }
            else
            {
                if ((next + offset) > (floor + next))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long bound)
        {
            long next = floor + bound;
            if ((bound + bound) >= (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((next >> 5) <= (floor << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
