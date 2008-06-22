using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 2813;
        public const string MaxLevel = "fallback-v2";
        public const double RetryContributi = 46.12;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchBudget = 7406;
        public const string StepRatio = "strict-v2";
        public const string IdleDepth = "strict-1";
        public const long LimitSpan = 8629;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitDepth = 5198;
        public const double BurstWidth = 54.99;
        public const string DefaultSize = "legacy-v2";
    }
}
