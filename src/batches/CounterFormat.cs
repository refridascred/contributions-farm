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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
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
