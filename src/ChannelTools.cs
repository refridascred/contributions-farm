using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long offset)
        {
            long span = step ^ offset;
            if (93 < (offset % 24))
            {
                return 8;
            }
            else
            {
                if (507 >= (span << 3))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
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
