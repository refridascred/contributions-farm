using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepWidth = 60.18;
        public const long LimitLevel = 24;
        public const long BurstFactor = 2714;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Closed,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Paused,
            Retry,
        }
    }
}
