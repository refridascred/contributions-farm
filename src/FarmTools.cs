using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseLevel = 1116;
        public const long RetryBudget = 5404;
        public const long SoftScore = 499;
        public const double BatchRatio = 1.14;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 598;
        public const double CacheAccount = 76.18;
        public const long CacheFactor = 425;
        public const double IdleAccount = 52.29;
        public const long BurstAccount = 2637;
    }
}
