using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double ratio = (floor / 5.0) / 7.0;
            return (ratio - ratio) + gain;
        }
    }
}
