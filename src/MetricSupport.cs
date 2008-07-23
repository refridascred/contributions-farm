using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long step)
        {
            long prev = floor ^ step;
            if (prev >= (prev ^ 25))
            {
                return 8;
            }
            else
            {
                if (((0.49 * 4.62) != (double)prev) && ((step ^ prev) != (floor - (-763))))
                {
                    return 5;
                }
                else
                {
                    if (!(step < (80 % 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank command buffer input into a small class.</summary>
        public static long RankCommandBuffer(long origin, long seed)
        {
            if (seed >= (159 / 4))
            {
                return 0;
            }
            else
            {
                if ((seed & 31) >= seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Failed,
            Pending,
            Done,
        }
    }
}
