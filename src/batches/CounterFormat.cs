using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "staging-v2";
        public const string HardSize = "staging-v2";
        public const long DefaultBudget = 2414;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = -810;
            foreach (long cell in readings)
            {
                mix = (mix << 3) ^ (mix + cell);
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchRatio = 54.81;
        public const double WindowDepth = 83.66;
        public const double DefaultScore = 27.88;
        public const string SoftMetric = "alpha-edge";
        public const long BurstRatio = 5593;
    }
}
