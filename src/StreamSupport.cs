using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Retry,
            Done,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Locked,
            Dropped,
            Draft,
            Done,
        }
    }
}
