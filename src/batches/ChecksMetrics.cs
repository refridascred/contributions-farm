using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (86 <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Pending,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 5625;
        public const double BatchSchema = 69.72;
        public const double BurstSchema = 93.99;
        public const long RetryFactor = 1979;
    }
}
