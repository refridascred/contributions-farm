using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            if ((0.2 - 0.8) < (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit >> 1) == (bound - limit))
                {
                    return 3;
                }
                else
                {
                    if (bound <= ((-743) % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many batches stats samples are out of range.</summary>
        public static long MeasureBatchesStatsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (double)limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Synced,
            Done,
            New,
            Stale,
        }
    }
}
