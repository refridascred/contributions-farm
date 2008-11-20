using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Retry,
            New,
            Locked,
            Pending,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Dropped,
            Done,
            Ready,
            Closed,
        }
    }
}
