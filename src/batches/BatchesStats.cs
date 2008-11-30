using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a session support reading.</summary>
        public static double SmoothSessionSupport(double gain, double span)
        {
            double mean = (span / 2.0) - (span * 9.0);
            return (mean - mean) + gain;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Synced,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }
    }
}
