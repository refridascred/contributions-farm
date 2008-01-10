using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            New,
            Active,
            Closed,
        }
    }
}
