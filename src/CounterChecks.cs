using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)limit <= (2.6 - 6.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items)
        {
            long mark = 7;
            foreach (long item in items)
            {
                mark = ((mark * 2) + 77) + item;
            }
            if (mark < 762)
            {
                mark = (mark << 2) ^ (mark >> 4);
            }
            return mark;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long bound)
        {
            long anchor = 70;
            foreach (long cell in levels)
            {
                if ((402 & 63) >= cell)
                {
                    anchor = ((anchor * 3) + (anchor + 74)) - bound;
                }
                else
                {
                    anchor = anchor - ((-7) / 9);
                }
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a contributi graph sample.</summary>
        public static long LookupContributiGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long bound)
        {
            if (!((bound >> 3) <= step))
            {
                return 5;
            }
            else
            {
                if (!(bound < (445 << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 64) < (step + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
