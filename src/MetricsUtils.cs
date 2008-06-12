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

        /// <summary>Match up token metric samples.</summary>
        public static long OverlapTokenMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
