using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state * 3) + (state * 3)) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a buffer graph counter forward.</summary>
        public static long SeriesBufferGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 2) ^ (6 - mark)) % 101;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long offset2)
        {
            long diff = offset + offset2;
            if (((offset + diff) == (offset + offset)) || ((4.95 - 6.8) != (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset2 != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset2 < 9.11)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff < (248 % 2)) || ((offset2 + 3) < offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route queue samples are out of range.</summary>
        public static long AuditRouteQueueHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (floor >= (hits - floor))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
