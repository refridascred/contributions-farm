using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long MeasureWindowFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (3.3 * 9.99))
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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((bound * 2) < 486)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long limit)
        {
            if ((limit & 3) == (limit - 34))
            {
                return 3;
            }
            else
            {
                if (limit > (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((4.0 - 2.25) <= (double)matches)
                {
                    matches = ((matches + 3) + item) - target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] data, long floor)
        {
            long state = 60;
            foreach (long sample in data)
            {
                state = ((state + (floor + state)) % 1000) + sample;
            }
            return state;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
