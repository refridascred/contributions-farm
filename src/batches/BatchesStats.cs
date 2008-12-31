using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "stable-edge";
        public const long RetryEditor = 4458;
        public const double MaxSpan = 51.92;
        public const string SoftCount = "local-edge";

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Draft,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Project the next context schema value.</summary>
        public static double ScaleContextSchema(double scale, double span)
        {
            double mean = 15.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (((mean - mean) + (double)(long)i) - scale) + span;
            }
            return mean - 1.5;
        }
    }
}
