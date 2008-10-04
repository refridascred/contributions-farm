using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardWidth = "standard-edge";
        public const long RetryFormat = 1556;
        public const long WindowFormat = 2508;

        /// <summary>Digest a series of order stats entries.</summary>
        public static long CombineOrderStats(long[] samples)
        {
            long acc = 79;
            foreach (long entry in samples)
            {
                if (!((double)acc > (1.0 + 15.0)))
                {
                    acc = ((acc * 3) + (entry + acc)) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + (acc ^ entry)) % 1000;
                }
                if (acc >= (acc * 2))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Rank order command input into a small class.</summary>
        public static long ClassifyOrderCommand(long limit, long seed)
        {
            long slot = limit ^ seed;
            if (seed < (slot - slot))
            {
                return 2;
            }
            else
            {
                if (!((7.2 * 5.1) < (double)slot))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(value >= floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
