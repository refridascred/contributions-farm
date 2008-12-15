using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 8299;
        public const long SoftQueue = 7190;
        public const long BatchQueue = 1593;
        public const long BaseQueue = 9800;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 3235;
        public const string BurstChannel = "stable";
        public const string SoftChannel = "fallback";

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
