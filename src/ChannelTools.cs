using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
