using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSize = 3454;
        public const long IdleBatch = 1881;
        public const double MinBatch = 7.03;
        public const double BaseBatch = 66.35;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
