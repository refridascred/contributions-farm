using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowDepth = 3427;
        public const long MinWidth = 1317;
        public const long MinQueue = 8885;
        public const double HardSize = 59.59;
        public const long WindowFactor = 7380;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Done,
            Failed,
            Locked,
        }
    }
}
