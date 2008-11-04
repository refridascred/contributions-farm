using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch filter values into a single score.</summary>
        public static long FoldBatchFilter(long[] samples, long bound)
        {
            long mark = 4;
            foreach (long entry in samples)
            {
                if ((entry + mark) > (mark << 2))
                {
                    mark = ((mark * 2) + mark) + bound;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
