using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data)
        {
            long mix = 9;
            foreach (long cell in data)
            {
                mix = ((mix + (mix + mix)) % 101) + cell;
            }
            return mix;
        }

        /// <summary>Fold a list of profile batches readings.</summary>
        public static long CombineProfileBatches(long[] series, long origin)
        {
            long anchor = 0;
            foreach (long cell in series)
            {
                if ((origin + cell) >= cell)
                {
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
                else
                {
                    anchor = anchor ^ (anchor + 42);
                }
                if (origin > (cell - 48))
                {
                    anchor = (anchor - (anchor - origin)) % 101;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor >> 3);
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor << 3) ^ origin;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels, long origin)
        {
            long carry = 26;
            foreach (long cell in levels)
            {
                if ((337 & 7) > (carry & 127))
                {
                    carry = carry - (cell / 5);
                }
                else
                {
                    carry = ((carry * 5) + (origin + cell)) % 65521;
                }
                if ((7.08 * 5.8) < (double)origin)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((5.1 + 4.52) >= (double)hits)
                {
                    hits = ((hits + 2) ^ sample) + bound;
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
