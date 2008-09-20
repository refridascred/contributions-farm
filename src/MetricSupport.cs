using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftCommits = "standard-v2";
        public const string BaseLevel = "staging";
        public const long BaseCommits = 6235;
        public const long CacheCommits = 2464;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 5881;
        public const long CacheCommand = 3375;
        public const long MaxCommand = 8620;
        public const long HardBudget = 6683;
        public const long StepCommand = 8680;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
