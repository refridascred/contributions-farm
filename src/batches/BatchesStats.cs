using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long AuditWindowStreamHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (bound - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6814;
        public const long LimitAccount = 8817;
        public const long WindowAccount = 4282;
        public const long BatchAccount = 8686;
        public const long RetryTimeout = 207;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryDepth = "local";
        public const long BatchInterval = 1772;
        public const long SoftTimeout = 5018;
        public const long StepWindow = 1929;
        public const long WindowDepth = 1682;
    }
}
