using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Paused,
            New,
            Done,
            Locked,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Synced,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 49.45;
        public const double SoftWidth = 51.88;
        public const double MinCommits = 22.3;
        public const long BatchInterval = 2694;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 86.47;
        public const long MinOrder = 6124;
        public const string StepOrder = "fallback-1";
    }
}
