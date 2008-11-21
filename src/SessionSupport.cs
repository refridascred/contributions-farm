using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 338;
        public const long RetryMetric = 3018;
        public const double BaseMetric = 67.98;
        public const double LimitLevel = 83.31;
        public const long WindowTimeout = 5318;
    }
}
