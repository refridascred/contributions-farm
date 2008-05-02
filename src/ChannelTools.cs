using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultFactor = 6415;
        public const long StepDepth = 7570;
        public const double WindowDepth = 25.55;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 4701;
        public const long StepLevel = 854;
        public const long IdleSession = 7675;
        public const long StepSession = 5942;
        public const long SoftBudget = 8878;
    }
}
