using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter metric samples are out of range.</summary>
        public static long AuditFilterMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (sample / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long offset)
        {
            if ((origin + origin) >= (origin ^ (-262)))
            {
                return 7;
            }
            else
            {
                if ((origin + offset) <= (origin >> 1))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seed <= (seed - seed)) || ((value + seed) == (value + value))) || ((double)seen <= (1.6 - 0.44)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Stale,
            Retry,
            Closed,
        }
    }
}
