using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of record session readings.</summary>
        public static long PairRecordSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long total = 189;
            foreach (long value in samples)
            {
                total = (total - total) % 101;
                total = total + (value >> 1);
            }
            return total;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark + ((long)i - 9);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
