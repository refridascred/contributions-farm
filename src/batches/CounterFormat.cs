using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((62 & 255) != (count + target)) || (((long)items.Length ^ (-5)) > (cell - 46))) && ((5 >= count) || ((count + target) <= 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the metric cache entries that pass the check.</summary>
        public static long AuditMetricCacheMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits > (9.8 * 4.91))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }
    }
}
