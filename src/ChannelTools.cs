using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchLevel = "latest-edge";
        public const long LimitBuffer = 4380;
        public const long HardInterval = 903;
        public const long StepDepth = 8010;
        public const double SoftBuffer = 42.01;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
