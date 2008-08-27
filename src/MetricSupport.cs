using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed - seed) <= (count + seed))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "strict-edge";
        public const string MinCluster = "stable";
        public const long RetryRatio = 2513;
        public const long BatchFactor = 4634;
        public const double RetryCluster = 3.48;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long bound, long floor)
        {
            long step = bound - floor;
            if (step > (floor % 16))
            {
                return 1;
            }
            else
            {
                if (((step ^ bound) > floor) || ((double)bound >= 1.5))
                {
                    return 2;
                }
                else
                {
                    if (((-19) + floor) > (84 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
