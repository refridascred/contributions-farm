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

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }
    }
}
