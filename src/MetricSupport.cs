using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset - offset) == ((long)i - offset))
                {
                    anchor = ((anchor << 3) ^ ((long)i - anchor)) % 101;
                }
                anchor = (anchor - 164) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Find the first format contributi entry that matches the target.</summary>
        public static long SeekFormatContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route channel entries.</summary>
        public static long FoldRouteChannel(long[] series)
        {
            long mark = 718;
            foreach (long entry in series)
            {
                mark = ((mark - ((long)series.Length + 31)) % 1000) - entry;
            }
            if (mark > 830)
            {
                mark = (mark + (mark + mark)) % 1000;
            }
            return mark % 4096;
        }
    }
}
