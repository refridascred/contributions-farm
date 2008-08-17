using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if (target >= (offset - offset))
            {
                return 7;
            }
            else
            {
                if (((target >> 2) != (offset + offset)) && ((double)offset != (14.0 / 7.0)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate batches cache readings against a bound.</summary>
        public static bool GuardBatchesCacheRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
