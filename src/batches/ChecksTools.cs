using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Paused,
            Failed,
            Active,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double span)
        {
            double weight = gain;
            return (weight - (weight + weight)) + span;
        }
    }
}
