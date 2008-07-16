using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window notes samples are out of range.</summary>
        public static long CountWindowNotesGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry - 9) > (floor + floor))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine notes schema values into a single score.</summary>
        public static long TotalNotesSchema(long[] readings)
        {
            long sum = 13;
            foreach (long value in readings)
            {
                sum = ((sum * 3) + (sum / 2)) % 65521;
                if ((((-545) & 31) == (sum ^ sum)) && (value <= (value << 1)))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum + (7 - 480);
            }
            return sum;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
