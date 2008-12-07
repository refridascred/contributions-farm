using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 4867;
        public const long MaxTools = 1204;
        public const double CacheTools = 68.38;
        public const long SoftTools = 8091;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Idle,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 2541;
        public const string LimitLevel = "stable-v2";
        public const string StepCommits = "alpha-1";
        public const string RetryRatio = "strict";
    }
}
