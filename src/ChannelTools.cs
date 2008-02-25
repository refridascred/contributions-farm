using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardRatio = 35.28;
        public const long IdleWindow = 6485;
        public const long MaxWindow = 2802;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 4083;
        public const string WindowCount = "strict-v2";
        public const double BurstFactor = 6.9;
        public const double BaseFactor = 52.12;
    }
}
