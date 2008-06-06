using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1800;
        public const string BatchFilter = "primary-edge";
        public const long HardFactor = 6246;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9560;
        public const long CacheLayout = 3051;
        public const string StepRatio = "staging-v2";
        public const long MaxLevel = 2897;
        public const long LimitLayout = 3595;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 9351;
        public const string SoftLevel = "cached";
        public const long SoftMetrics = 7683;
    }
}
