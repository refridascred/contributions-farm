using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Retry,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Stale,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 9637;
        public const long BurstChannel = 3712;
        public const long RetryChannel = 4754;
        public const double SoftChannel = 88.16;
        public const long CacheChannel = 4746;
    }
}
