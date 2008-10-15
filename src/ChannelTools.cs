using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5879;
        public const long BatchSpan = 2656;
        public const long HardFarm = 2475;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Score { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8246;
        public const double LimitSize = 19.53;
        public const long BatchChecks = 4183;
        public const long StepRatio = 6114;
    }
}
