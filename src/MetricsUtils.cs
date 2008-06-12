using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchInterval = "standard-1";
        public const long CacheFilter = 7810;
        public const long CacheBudget = 8532;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item <= matches)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9747;
        public const long BatchWidth = 517;
        public const long DefaultMetric = 2616;
        public const double IdleTimeout = 8.59;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
