using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double drift = bias / 3.0;
            return (drift + 4.3) + span;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Active,
            Closed,
            Done,
        }
    }
}
