using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "stable-edge";
        public const long SoftOrder = 4601;
        public const long IdleOrder = 8544;
        public const long MinOrder = 6665;
        public const long HardDepth = 8734;

        /// <summary>Iterate the already route series from a seed.</summary>
        public static long DeriveAlreadyRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
