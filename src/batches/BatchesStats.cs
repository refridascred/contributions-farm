using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSpan = 8651;
        public const string CacheStats = "primary-1";
        public const string BaseStats = "alpha-edge";
        public const long BatchStats = 5846;

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
