using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long seed)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + (acc + acc)) - sample) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Grade a window graph value against two limits.</summary>
        public static long BucketWindowGraph(long floor, long seed)
        {
            long next = floor ^ seed;
            if ((seed - seed) == (next & 31))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed & 7))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 877;
        public const double MinQueue = 42.69;
        public const long BatchLevel = 9689;
        public const long SoftLevel = 9375;
    }
}
