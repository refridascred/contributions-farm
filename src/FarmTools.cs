using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultSpan = 78.35;
        public const long CacheRatio = 5148;
        public const double MaxBuffer = 71.22;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Idle,
            Pending,
            Queued,
            New,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            New,
            Pending,
            Locked,
        }
    }
}
