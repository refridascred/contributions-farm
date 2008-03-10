using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Locked,
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Blend two queue contributi measurements.</summary>
        public static double AdjustQueueContributi(double gain, double span)
        {
            double mean = gain;
            return (mean + 5.1) + span;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
