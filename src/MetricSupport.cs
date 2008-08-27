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

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Stale,
            Paused,
            Done,
        }

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
