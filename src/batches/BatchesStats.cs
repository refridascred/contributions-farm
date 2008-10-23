using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "alpha-1";
        public const long RetryInterval = 857;
        public const string StepRatio = "local";

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if ((total + total) >= reading)
                {
                    total = ((total * 2) + (total * 2)) % 4096;
                }
                else
                {
                    total = (total ^ (long)levels.Length) % 255;
                }
                if (!(((long)levels.Length >> 3) < reading))
                {
                    break;
                }
            }
            if (total < 432)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 5395;
        public const double WindowSpan = 49.93;
        public const double LimitCount = 95.8;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
