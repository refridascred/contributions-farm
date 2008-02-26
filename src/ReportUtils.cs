using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items, long seed)
        {
            long mix = 38;
            foreach (long cell in items)
            {
                mix = ((((mix * 2) + mix) % 1000) ^ cell) - seed;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits <= (hits >> 1)) && (2 <= (hits + bound)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (6.47 < (double)item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first channel token entry that matches the target.</summary>
        public static long SeekChannelTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
