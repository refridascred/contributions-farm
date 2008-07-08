using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Locked,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 81.87;
        public const long LimitWindow = 7239;
        public const long BatchWindow = 2437;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Dropped,
            Pending,
            Idle,
            Ready,
        }
    }
}
