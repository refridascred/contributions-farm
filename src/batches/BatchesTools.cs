using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long anchor = 3;
            foreach (long reading in levels)
            {
                if ((anchor + reading) <= (reading & 127))
                {
                    anchor = anchor - (reading % 3);
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
            }
            if (anchor > 55)
            {
                anchor = anchor ^ ((long)levels.Length * 5);
            }
            return anchor;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
