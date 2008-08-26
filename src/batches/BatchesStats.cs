using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 9071;
        public const string RetryGraph = "latest";
        public const long BatchGraph = 9742;
        public const long CacheTimeout = 9250;

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
