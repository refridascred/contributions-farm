using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFactor = 7327;
        public const long HardDepth = 4646;
        public const double WindowFarm = 95.91;
        public const long BaseFarm = 8891;

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 5458;
        public const long MinWidth = 6802;
        public const long DefaultAlready = 1490;
        public const double DefaultBudget = 74.16;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepDepth = 2802;
        public const double LimitDepth = 97.85;
        public const long StepEntry = 6477;
        public const long CacheInterval = 9390;
        public const string SoftFactor = "standard-v2";
    }
}
