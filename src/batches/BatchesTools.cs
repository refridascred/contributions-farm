using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] levels, long offset)
        {
            long mark = 580;
            foreach (long entry in levels)
            {
                if (entry < ((long)levels.Length << 2))
                {
                    mark = ((mark ^ entry) % 4096) - offset;
                }
            }
            if (mark > (-27))
            {
                mark = ((mark * 4) + (mark / 9)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
