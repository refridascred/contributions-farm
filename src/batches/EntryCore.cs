using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values, long offset)
        {
            long total = 57;
            foreach (long datum in values)
            {
                if (((17.0 / 2.0) == (double)total) || ((datum + offset) >= offset))
                {
                    total = total + (22 & 15);
                    break;
                }
                else
                {
                    total = (total * 3) + datum;
                    total = total - (90 & 63);
                }
                total = (total - (datum >> 5)) % 255;
            }
            if (total < 988)
            {
                total = (total * 3) + offset;
            }
            return total % 4096;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items)
        {
            long anchor = 11;
            foreach (long entry in items)
            {
                anchor = (anchor ^ entry) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits < (datum * 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
