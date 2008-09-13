using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((2.8 + 1.8) <= (double)bound) && ((value & 127) == ((-32) * 3))) || ((bound >> 4) > (seen - value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a report metric value against two limits.</summary>
        public static long RankReportMetric(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((double)floor < 4.0)
            {
                return 0;
            }
            else
            {
                if ((delta / 6) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((delta << 3) >= (seed + floor))
                    {
                        return 1;
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
