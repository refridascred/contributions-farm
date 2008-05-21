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

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public double Flag { get; set; }
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
