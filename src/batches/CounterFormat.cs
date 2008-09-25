using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batches channel values into a single score.</summary>
        public static long TallyBatchesChannel(long[] values, long limit)
        {
            long mark = 543;
            foreach (long cell in values)
            {
                if (cell <= mark)
                {
                    mark = mark - (mark - 2);
                }
                else
                {
                    mark = mark + (limit >> 2);
                }
            }
            if (mark < 1)
            {
                mark = (mark << 3) ^ 62;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + mark) != (bound - 618))
                {
                    mark = (mark + mark) % 255;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
