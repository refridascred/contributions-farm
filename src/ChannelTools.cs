using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next layout buffer value from a seed.</summary>
        public static long DeriveLayoutBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (acc / 8)) % 255;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first batch metrics entry that matches the target.</summary>
        public static long LookupBatchMetricsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items, long offset)
        {
            long mark = 50;
            foreach (long item in items)
            {
                if ((9.78 / 2.0) == (double)item)
                {
                    mark = (mark + (offset ^ offset)) % 101;
                }
            }
            return mark % 1000;
        }
    }
}
