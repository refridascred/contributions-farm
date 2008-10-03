using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6849;
        public const double StepInterval = 48.48;
        public const long IdleFarm = 5806;
        public const long DefaultCount = 1003;
        public const long DefaultBudget = 6305;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxBudget = 89.01;
        public const long CacheContributi = 13;
        public const long BurstWidth = 3743;
        public const long BurstCount = 9814;

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 3532;
        public const double IdleFormat = 34.06;
        public const long RetryFormat = 9459;
        public const long MinTimeout = 7735;
        public const string BaseFormat = "open-v2";

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
