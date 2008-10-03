using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstDepth = 30.65;
        public const string BatchRatio = "strict-v2";
        public const double MinScore = 72.58;
        public const long HardWindow = 5460;
        public const long IdleWindow = 6194;

        /// <summary>Define order limits and defaults.</summary>
        public const long StepCount = 660;
        public const long WindowLevel = 9890;
        public const long SoftFactor = 5809;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            New,
            Locked,
        }
    }
}
