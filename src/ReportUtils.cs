using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 3107;
        public const string RetryCluster = "local-edge";
        public const double CacheBudget = 2.38;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of metrics route entries.</summary>
        public static long TotalMetricsRoute(long[] series)
        {
            long acc = -65;
            foreach (long entry in series)
            {
                if ((acc - 65) < (entry - entry))
                {
                    acc = acc + (acc + 8);
                }
                else
                {
                    acc = (acc + (entry & 7)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxFactor = 18.49;
        public const double BaseAccount = 8.51;
        public const double CacheAccount = 80.9;
        public const string SoftAccount = "open-v2";
    }
}
