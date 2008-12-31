using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Done,
            Failed,
        }
    }
}
