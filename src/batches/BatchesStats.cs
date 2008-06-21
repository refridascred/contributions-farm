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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 60.06;
        public const string LimitFactor = "cached-v2";
        public const long SoftLevel = 2463;
        public const long LimitSize = 9955;
        public const long SoftBudget = 2731;

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
