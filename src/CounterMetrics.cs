using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "stable-v2";
        public const long BatchAlready = 968;
        public const string WindowFactor = "local-v2";

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Synced,
            Paused,
            Pending,
            Stale,
        }
    }
}
