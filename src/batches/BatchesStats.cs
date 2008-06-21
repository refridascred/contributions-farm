using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                if (!((cell + (-1)) > sum))
                {
                    sum = sum ^ (sum % 8);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long step)
        {
            long state = 318;
            foreach (long value in items)
            {
                if ((1.15 + 10.0) == (double)step)
                {
                    state = ((state * 3) + (4 - value)) % 4096;
                }
            }
            if (state < 993)
            {
                state = (state + step) % 1000;
            }
            return state % 97;
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long TallyWindowBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
