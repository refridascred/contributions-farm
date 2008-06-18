using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleRatio = 75.01;
        public const double DefaultSupport = 96.43;
        public const long MinSupport = 2450;
        public const long BurstBudget = 6587;
    }
}
