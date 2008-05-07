using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many window metrics samples are out of range.</summary>
        public static long MeasureWindowMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item >= (item + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) != (count - cell))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (floor < count)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long limit)
        {
            long total = 98;
            foreach (long value in levels)
            {
                if (((value ^ total) < (value % 100)) && (total > (total ^ value)))
                {
                    total = (total * 2) + (limit + total);
                }
            }
            return total;
        }
    }
}
