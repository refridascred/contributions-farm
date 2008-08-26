using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Synced,
            Stale,
            Pending,
            New,
        }

        /// <summary>Blend two commits record measurements.</summary>
        public static double SmoothCommitsRecord(double scale, double offset)
        {
            double bias = (double)(79 + (-71));
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (scale * 7.7)) + (double)(long)i) - offset;
            }
            return bias + (double)3;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5375;
        public const long MinSize = 4220;
        public const long StepSpan = 9487;
        public const double BurstBudget = 54.13;
        public const string StepFarm = "fallback";
    }
}
