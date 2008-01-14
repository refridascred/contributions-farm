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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxScore = 3973;
        public const string DefaultLevel = "fallback";
        public const long BaseTools = 3632;
        public const long MaxTools = 1351;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
