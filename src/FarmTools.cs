using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5823;
        public const double RetryCount = 95.28;
        public const string LimitChannel = "cached-1";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Stale,
            Dropped,
        }
    }
}
