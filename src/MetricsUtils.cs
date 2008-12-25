using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Locked,
            Pending,
            New,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Done,
            Paused,
        }
    }
}
