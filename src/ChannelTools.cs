using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Done,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSize = 1899;
        public const double WindowFactor = 79.1;
        public const long MinLevel = 6310;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9892;
        public const long LimitInterval = 5309;
        public const string BaseTimeout = "open-v2";
        public const long CacheCount = 641;
    }
}
