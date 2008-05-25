using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of entry batch entries.</summary>
        public static long TallyEntryBatch(long[] items)
        {
            long result = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length * 5) > ((-1) >> 2))
                {
                    result = (result + (cell / 5)) % 4096;
                }
            }
            if (result > 654)
            {
                result = (result * 4) + (result / 6);
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 2) ^ ((-3) - floor);
                anchor = (anchor - ((long)i + (long)i)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
