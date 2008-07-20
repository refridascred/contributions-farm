using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Done,
            Draft,
            Ready,
            New,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Locked,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSpan = 28.16;
        public const long BurstProfile = 3291;
        public const long HardWidth = 2645;
        public const double BatchBudget = 1.05;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Retry,
            New,
            Closed,
        }
    }
}
