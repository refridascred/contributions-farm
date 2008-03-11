using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            New,
            Retry,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchBudget = 7526;
        public const string CacheRecord = "cached-v2";
        public const long StepScore = 1931;
        public const long HardScore = 9411;

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 74.9;
        public const long MinContext = 2992;
        public const long CacheContext = 9974;
        public const long MinWidth = 9778;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Paused,
            Dropped,
            Done,
        }
    }
}
