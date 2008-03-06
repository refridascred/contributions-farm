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

        /// <summary>Digest a series of stats command entries.</summary>
        public static long WeighStatsCommand(long[] series)
        {
            long total = 1;
            foreach (long entry in series)
            {
                if (total > 729)
                {
                    total = total - (entry & 7);
                }
                else
                {
                    total = total ^ total;
                    total = (total * 3) + (8 + 34);
                }
                total = (total * 4) + total;
            }
            return total;
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
