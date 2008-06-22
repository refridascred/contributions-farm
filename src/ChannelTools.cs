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

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheBudget = 7601;
        public const long DefaultWidth = 8824;
        public const long SoftContext = 4858;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitDepth = 5198;
        public const double BurstWidth = 54.99;
        public const string DefaultSize = "legacy-v2";
    }
}
