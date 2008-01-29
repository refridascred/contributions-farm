using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 1630;
        public const long BaseScore = 3181;
        public const double StepScore = 70.33;
        public const double BaseGraph = 56.58;
        public const long CacheGraph = 3728;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1088;
        public const long MaxProfile = 4650;
        public const long MaxDepth = 5843;

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long SeriesToolsCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 3) ^ (limit & 127)) % 97;
                mix = mix + limit;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Closed,
            Stale,
            Active,
            Locked,
        }
    }
}
