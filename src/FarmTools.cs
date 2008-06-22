using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "open";
        public const double StepGraph = 58.94;
        public const long HardSize = 2074;
        public const double BatchFactor = 15.73;
        public const string WindowGraph = "local";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            New,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
