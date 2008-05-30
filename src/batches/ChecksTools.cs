using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long limit)
        {
            long bound = offset - limit;
            if (!((double)offset >= 20.0))
            {
                return 7;
            }
            else
            {
                if ((limit ^ limit) <= (limit ^ bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (9.6 - 4.5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset >> 1) < offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long offset)
        {
            if (!((double)limit <= (7.4 * 12.0)))
            {
                return 2;
            }
            else
            {
                if (((limit >> 3) > offset) && ((13 << 3) <= (offset + 99)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
