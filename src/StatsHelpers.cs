using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string CacheRatio = "latest-v2";
        public const long WindowSession = 8445;
        public const string MaxSession = "primary-1";
        public const long HardSession = 5389;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 1902;
        public const string DefaultNotes = "cached-1";
        public const long WindowNotes = 7685;

        /// <summary>Count the batch cache entries that pass the check.</summary>
        public static long AuditBatchCacheOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((1.8 * 4.0) != (double)matches)
                {
                    matches = ((matches + 2) ^ reading) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
