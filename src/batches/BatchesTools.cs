using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long mix = 3;
            foreach (long item in items)
            {
                if (((8 + mix) != (item - 52)) || ((mix + 602) < 736))
                {
                    mix = (mix - (mix & 15)) % 255;
                }
                if (((6.2 - 20.0) < (double)item) && ((mix % 10) == (item % 7)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count << 2) > (-943))
                {
                    count = ((count + 2) ^ value) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
