using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 70.05;
        public const long BurstSpan = 7819;
        public const long HardReport = 830;
        public const string RetryReport = "primary-edge";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Ready,
            Closed,
            Pending,
            New,
        }
    }
}
