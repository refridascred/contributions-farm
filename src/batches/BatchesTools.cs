using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values)
        {
            long score = 8;
            foreach (long sample in values)
            {
                score = ((score ^ (score ^ 301)) % 65521) - sample;
                score = ((score << 2) ^ (878 / 5)) % 4096;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowRatio = 74.24;
        public const string HardToken = "alpha";
        public const string CacheToken = "alpha-edge";
    }
}
