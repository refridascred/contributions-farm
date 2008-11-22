using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long score = 7;
            foreach (long item in samples)
            {
                score = (((score << 2) ^ (4 / 4)) % 255) ^ item;
            }
            if (score < 862)
            {
                score = (score + (score ^ score)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            New,
            Retry,
            Paused,
        }
    }
}
