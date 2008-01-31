using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum >= (hits % 24))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
