using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRatio = 58.09;
        public const long BaseRecord = 702;
        public const long DefaultRecord = 3071;
        public const string HardRatio = "stable-v2";

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Closed,
            Dropped,
            Stale,
        }
    }
}
