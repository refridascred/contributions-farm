using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseScore = 26;
        public const long StepWidth = 4267;
        public const string WindowWidth = "open-v2";
        public const long BurstDepth = 3355;
        public const long IdleReport = 6875;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9675;
        public const string HardRoute = "open-edge";
        public const long IdleSize = 8574;
        public const long BatchScore = 7149;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 2742;
        public const long LimitRatio = 8312;
        public const long IdleMetrics = 3921;
    }
}
