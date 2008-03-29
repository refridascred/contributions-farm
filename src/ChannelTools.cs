using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheScore = 2092;
        public const long MinFormat = 6764;
        public const double HardFormat = 90.37;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 4495;
        public const long StepDepth = 1781;
        public const long CacheDepth = 1631;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
