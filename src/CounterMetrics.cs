using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long ClassifyBatchesRoute(long target, long limit)
        {
            long lane = target - limit;
            if ((double)lane == (0.28 / 6.0))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 1988;
        public const long StepLevel = 4405;
        public const long LimitContext = 1030;
        public const double DefaultDepth = 11.61;

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepInterval = 27.14;
        public const string HardRatio = "open";
        public const double HardSpan = 98.51;
        public const long CacheWidth = 1735;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                score = ((score * 2) + score) + datum;
            }
            return score;
        }
    }
}
