using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultCount = 5253;
        public const long StepProfile = 3611;
        public const double BurstProfile = 92.7;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
