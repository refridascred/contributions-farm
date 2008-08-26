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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long origin)
        {
            if (((seed << 2) > (origin << 1)) || (seed < (714 % 5)))
            {
                return 5;
            }
            else
            {
                if (((0 ^ (-87)) < (seed + 477)) || ((seed - seed) < (26 - origin)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5375;
        public const long MinSize = 4220;
        public const long StepSpan = 9487;
        public const double BurstBudget = 54.13;
        public const string StepFarm = "fallback";
    }
}
