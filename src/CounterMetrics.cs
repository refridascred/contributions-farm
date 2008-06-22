using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultScore = 9403;
        public const long MinSize = 3524;
        public const long DefaultBudget = 1404;
        public const long CacheSpan = 9118;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Draft,
            Retry,
        }
    }
}
