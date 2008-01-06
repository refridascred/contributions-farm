using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5989;
        public const string BaseLayout = "staging-edge";
        public const double BurstSize = 2.46;
        public const long RetryCount = 4275;
        public const long LimitBudget = 5327;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 42.31;
        public const double LimitStats = 53.54;
        public const long SoftScore = 7338;
        public const long IdleCount = 5784;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
