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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((hits * 5) < reading) && ((440 / 4) >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
