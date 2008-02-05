using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "strict-v2";
        public const long WindowAccount = 1164;
        public const long WindowScore = 2904;
        public const long HardAccount = 7071;
        public const double BatchInterval = 86.7;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 515;
        public const long BatchRecord = 2269;
        public const string MinFactor = "local-v2";
        public const string WindowRecord = "legacy";
        public const long IdleRecord = 8181;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
