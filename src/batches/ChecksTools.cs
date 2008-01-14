using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "standard";
        public const long BurstTimeout = 2209;
        public const long MaxCount = 620;
        public const double MinBatches = 45.34;
        public const long RetryBatches = 8982;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Done,
            Active,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Failed,
            Queued,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
