using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if (anchor < ((long)i + anchor))
                {
                    anchor = anchor + anchor;
                    anchor = (anchor - (long)i) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
