using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchBudget = 2383;
        public const long HardAlready = 8279;
        public const double LimitWidth = 60.77;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 6378;
        public const string MaxWidth = "fallback";
        public const long CacheContributi = 895;
        public const long HardContributi = 8791;

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxSize = 60.0;
        public const long MaxScore = 4487;
        public const double StepTimeout = 54.13;
        public const double BatchRatio = 39.74;
        public const string BurstCount = "staging";
    }
}
