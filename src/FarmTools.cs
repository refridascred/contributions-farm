using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2306;
        public const double LimitContributi = 51.63;
        public const long StepContributi = 6274;
        public const long CacheContributi = 7533;
        public const long BurstContributi = 7165;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleTimeout = 7916;
        public const double BurstFarm = 15.16;
        public const string LimitBudget = "legacy";
        public const string HardFarm = "open";

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinBudget = 7246;
        public const long CacheFactor = 2772;
        public const long SoftCount = 8324;
        public const string IdleSchema = "latest";
    }
}
