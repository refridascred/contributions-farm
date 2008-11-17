using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 565;
        public const long HardRatio = 6105;
        public const double CacheFactor = 1.09;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Locked,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
