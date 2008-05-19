using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryRatio = 4753;
        public const long HardCount = 5751;
        public const long MinDepth = 7095;
        public const long BatchScore = 6988;
        public const long HardStats = 2936;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 767;
        public const double DefaultMetric = 63.63;
        public const double HardMetric = 21.58;
        public const long BurstMetric = 9999;
        public const long SoftLevel = 2342;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((acc / 4) != ((-984) + limit))
                {
                    acc = (acc + 81) % 255;
                    break;
                }
                acc = (acc ^ limit) % 1000;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
