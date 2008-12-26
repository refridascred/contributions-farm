using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double bias = (double)(0 + 67);
            return (bias + (7.3 + span)) + scale;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long limit)
        {
            long edge = seed ^ limit;
            if ((edge >> 3) >= (edge / 9))
            {
                return 3;
            }
            else
            {
                if ((7.7 + 0.83) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxDepth = "alpha-edge";
        public const long WindowTimeout = 1856;
        public const long RetryRecord = 3006;
        public const long BatchRecord = 2874;
    }
}
