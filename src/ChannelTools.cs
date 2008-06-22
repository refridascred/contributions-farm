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
        public const long RetryBuffer = 5292;
        public const long MinBuffer = 6367;
        public const string BatchBuffer = "open-v2";
        public const string BatchScore = "latest-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitDepth = 5198;
        public const double BurstWidth = 54.99;
        public const string DefaultSize = "legacy-v2";
    }
}
