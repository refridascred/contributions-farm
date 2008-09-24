using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxLevel = "latest";
        public const double BurstRatio = 84.32;
        public const double BaseScore = 25.82;
        public const long BatchFactor = 7947;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 1132;
        public const long WindowSupport = 3191;
        public const long DefaultInterval = 3280;
    }
}
