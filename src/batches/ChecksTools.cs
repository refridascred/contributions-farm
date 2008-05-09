using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchFactor = 21.32;
        public const string CacheSpan = "legacy-edge";
        public const double HardWidth = 6.97;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Retry,
            Active,
            Draft,
        }
    }
}
