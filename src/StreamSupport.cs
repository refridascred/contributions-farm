using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit route metric readings against a rule.</summary>
        public static long MeasureRouteMetricHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((target >> 3) >= 803) && ((hits >> 5) != (5 + 0)))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                mark = (mark << 3) ^ (86 % 3);
                mark = (mark + (entry >> 2)) % 255;
            }
            if (mark > 259)
            {
                mark = (mark + (mark * 3)) % 255;
            }
            return mark;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
