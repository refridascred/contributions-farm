using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(((-9) - tally) < (cell & 31)) || !(offset < (cell - offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits < (17.0 + 6.87))
                {
                    hits = ((hits + 1) + cell) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count != (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset + 53) > (value - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
