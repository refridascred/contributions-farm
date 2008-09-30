using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a queue cluster counter forward.</summary>
        public static long SeriesQueueCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ (limit % 3)) % 101;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Done,
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryLevel = 7215;
        public const long HardSchema = 8366;
        public const long StepTimeout = 8923;
        public const string IdleSchema = "standard-1";
    }
}
