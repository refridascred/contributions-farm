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

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
