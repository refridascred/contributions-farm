using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 2.33;
        public const long BaseInterval = 8559;
        public const double LimitSpan = 59.85;
        public const double BatchScore = 4.83;

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long bound)
        {
            long acc = -1;
            foreach (long sample in data)
            {
                acc = ((acc << 2) ^ bound) + sample;
            }
            return acc;
        }
    }
}
