using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 5339;
        public const long BurstQueue = 5605;
        public const long LimitQueue = 1987;
        public const long HardDepth = 4225;
        public const string HardQueue = "staging-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstWidth = 593;
        public const string BatchLevel = "cached";
        public const double CacheCount = 94.71;
        public const long LimitSchema = 1606;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
