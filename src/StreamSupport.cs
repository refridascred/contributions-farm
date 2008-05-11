using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 8697;
        public const long BatchCount = 173;
        public const long IdleQueue = 8933;
        public const double BurstQueue = 12.85;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Draft,
            Dropped,
            Queued,
        }
    }
}
