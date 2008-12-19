using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream commits values into a single score.</summary>
        public static long WeighStreamCommits(long[] series, long offset)
        {
            long sum = 745;
            foreach (long cell in series)
            {
                sum = (sum ^ (offset ^ cell)) % 97;
                sum = sum - (sum << 1);
                if (sum > (cell ^ sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
