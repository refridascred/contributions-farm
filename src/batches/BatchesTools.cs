using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (total - (long)i)) % 97;
                total = (total + total) % 4096;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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
