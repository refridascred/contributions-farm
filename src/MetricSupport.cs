using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Stale,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
