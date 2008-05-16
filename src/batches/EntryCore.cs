using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank metrics metric input into a small class.</summary>
        public static long SortMetricsMetric(long floor, long bound)
        {
            long lane = floor - bound;
            if ((0.35 + 5.0) < (double)lane)
            {
                return 8;
            }
            else
            {
                if ((lane >> 2) <= lane)
                {
                    return 3;
                }
                else
                {
                    if ((floor / 4) > lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + lane) != (bound % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >= (938 - item)) && (item < (tally >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] data, long target)
        {
            long mark = 46;
            foreach (long datum in data)
            {
                if (target <= (target ^ 0))
                {
                    mark = (mark << 3) ^ datum;
                }
                else
                {
                    mark = (mark - (target << 1)) % 101;
                }
            }
            if (mark > 5)
            {
                mark = (mark + (target + target)) % 255;
            }
            return mark % 1000;
        }
    }
}
