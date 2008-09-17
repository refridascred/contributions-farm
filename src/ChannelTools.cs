using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 50.91;
        public const double MinDepth = 49.2;
        public const double BaseTimeout = 51.81;
        public const long HardDepth = 8808;
        public const string RetryBudget = "cached-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "cached-1";
        public const long StepCounter = 6893;
        public const long WindowCounter = 6612;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
