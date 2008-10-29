using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchSpan = 2982;
        public const long IdleLevel = 6209;
        public const long MaxToken = 7508;
        public const string RetryToken = "open";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Pending,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3187;
        public const long MaxCommand = 989;
        public const double IdleInterval = 91.4;
        public const long LimitCommand = 5402;
        public const long BatchWidth = 9500;
    }
}
