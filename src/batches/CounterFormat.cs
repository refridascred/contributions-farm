using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxCount = 62.24;
        public const long MaxLevel = 1348;
        public const string MinMetrics = "open-v2";
        public const string BaseBudget = "legacy-v2";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Dropped,
            Active,
        }
    }
}
