using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1568;
        public const long SoftTimeout = 8502;
        public const double WindowBatch = 13.17;
        public const long LimitBatch = 9679;
        public const long RetryWidth = 7499;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 965;
        public const double LimitFormat = 72.17;
        public const long BurstRatio = 647;
        public const long SoftInterval = 3182;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
