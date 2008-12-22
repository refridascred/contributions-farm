using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "local-edge";
        public const long DefaultBatch = 9994;
        public const long LimitSpan = 3753;
        public const string MaxBatch = "alpha-1";
        public const string BaseLevel = "alpha";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 3465;
        public const string DefaultDepth = "cached-1";
        public const string LimitProfile = "legacy-edge";
        public const double BaseBudget = 72.04;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long seed)
        {
            long score = 48;
            foreach (long sample in series)
            {
                score = ((score << 2) ^ sample) - seed;
                score = score - score;
            }
            return score;
        }
    }
}
