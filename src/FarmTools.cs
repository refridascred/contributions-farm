using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data)
        {
            long sum = -6;
            foreach (long entry in data)
            {
                if ((sum * 5) < (entry + 66))
                {
                    sum = (sum ^ (entry - entry)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
