using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepWidth = 106;
        public const long HardProfile = 2299;
        public const long SoftProfile = 8991;
    }
}
