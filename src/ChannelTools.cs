using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 3533;
        public const long LimitContributi = 7686;
        public const double IdleFactor = 98.63;
        public const string DefaultContributi = "stable-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinWidth = 789;
        public const double CacheMetrics = 54.61;
        public const double RetryBudget = 60.32;
        public const long StepMetrics = 1629;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Active,
            Dropped,
            Queued,
        }
    }
}
