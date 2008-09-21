using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "stable";
        public const long BurstBatches = 4970;
        public const long BurstSize = 7296;
        public const long BaseTimeout = 8387;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
