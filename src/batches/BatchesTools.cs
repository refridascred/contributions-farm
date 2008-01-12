using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheBudget = 4646;
        public const long SoftEditor = 9279;
        public const long CacheInterval = 3170;
        public const string HardCount = "latest-1";

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i << 2) <= (sum << 2)) || ((double)limit > (2.0 / 4.0)))
                {
                    sum = (sum ^ (limit ^ sum)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                anchor = (anchor * 2) + 596;
                if ((double)(-1) == (double)item)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
