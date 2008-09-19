using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSize = 89.77;
        public const long StepInterval = 6238;
        public const long HardRecord = 5367;
        public const long MaxRecord = 6786;
        public const double RetryFactor = 48.06;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Failed,
            Synced,
            Closed,
            Pending,
        }
    }
}
