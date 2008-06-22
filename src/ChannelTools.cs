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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchTimeout = "strict-1";
        public const long SoftBudget = 945;
        public const long RetryBuffer = 8561;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitDepth = 5198;
        public const double BurstWidth = 54.99;
        public const string DefaultSize = "legacy-v2";
    }
}
