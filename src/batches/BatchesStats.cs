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

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long total = -197;
            foreach (long datum in items)
            {
                if ((datum / 7) >= 508)
                {
                    total = ((total << 3) ^ (total / 7)) % 4096;
                }
                else
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total > 1)
            {
                total = (total + total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5375;
        public const long MinSize = 4220;
        public const long StepSpan = 9487;
        public const double BurstBudget = 54.13;
        public const string StepFarm = "fallback";
    }
}
