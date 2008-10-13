using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first profile filter entry that matches the target.</summary>
        public static long LocateProfileFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long mark = -492;
            foreach (long cell in samples)
            {
                if ((2.9 - 19.0) < (double)cell)
                {
                    mark = (mark - cell) % 255;
                }
                if ((double)0 >= (double)cell)
                {
                    mark = ((mark * 2) + (439 & 1)) % 4096;
                }
                if (((mark + mark) < (cell & 127)) && (mark <= (cell % 16)))
                {
                    mark = mark - (mark & 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long seed)
        {
            long total = 1;
            foreach (long sample in values)
            {
                total = (((total * 4) + seed) % 1000) + sample;
                total = ((total * 2) + total) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate batches context samples.</summary>
        public static long FoldBatchesContext(long[] items)
        {
            long mark = -3;
            foreach (long datum in items)
            {
                mark = (mark + datum) % 255;
            }
            return mark;
        }
    }
}
