using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Pending,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Retry,
            Idle,
            Dropped,
        }
    }
}
