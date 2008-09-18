using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardTimeout = 3284;
        public const long StepSize = 1716;
        public const string CacheLayout = "legacy-1";
        public const long BatchLayout = 5858;
        public const double MaxBudget = 95.78;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Paused,
            Retry,
            Synced,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
