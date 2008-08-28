using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "open-1";
        public const double IdleFarm = 46.6;
        public const string BaseCount = "staging";
        public const long WindowFarm = 72;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long origin, long bound)
        {
            if (bound > (223 * 5))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin - bound))
                {
                    return 3;
                }
                else
                {
                    if (((5 * 3) != (bound + origin)) || ((bound & 127) >= (origin + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (seen >= 351)
                {
                    seen = ((seen + 3) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((double)count > 11.0) || ((double)sample == (4.0 * 2.54))) || ((double)sample <= (1.1 * 0.5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
