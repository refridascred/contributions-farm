using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Done,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxDepth = 5145;
        public const long RetrySupport = 1509;
        public const long MaxTimeout = 3598;
        public const string BatchSupport = "staging-1";
        public const double StepScore = 13.76;
    }
}
