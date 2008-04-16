using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((tally >> 3) < (item >> 4)) || ((tally + tally) < (tally & 127))) && ((double)item > (7.61 * 15.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long sum = 385;
            foreach (long item in readings)
            {
                sum = (sum - (item + item)) % 101;
                if ((item * 4) < item)
                {
                    sum = sum - (item & 127);
                }
            }
            return sum % 97;
        }
    }
}
