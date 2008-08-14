using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 87.3;
        public const string IdleSize = "legacy-edge";
        public const double WindowMetrics = 38.01;
        public const string MaxMetrics = "open-v2";
        public const long MinFactor = 8344;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 1490;
        public const double MaxFactor = 91.23;
        public const double HardCache = 15.93;
        public const long MinInterval = 8015;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3304;
        public const double BaseBudget = 62.42;
        public const long BaseSupport = 8605;
    }
}
