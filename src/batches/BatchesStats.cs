using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6429;
        public const long BatchStats = 1809;
        public const string WindowStats = "cached-1";

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 960;
            foreach (long entry in data)
            {
                if (!((8.99 - 4.0) <= (double)entry))
                {
                    sum = sum ^ (sum & 255);
                }
                else
                {
                    sum = (sum << 2) ^ (entry + entry);
                }
            }
            return sum % 1000;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items)
        {
            long sum = 146;
            foreach (long item in items)
            {
                if (item < 45)
                {
                    sum = sum - item;
                }
            }
            if (sum > 228)
            {
                sum = ((sum * 4) + (908 << 1)) % 255;
            }
            return sum % 4096;
        }
    }
}
