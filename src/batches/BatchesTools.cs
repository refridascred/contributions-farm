using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
