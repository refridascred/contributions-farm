using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long offset)
        {
            long state = 7;
            foreach (long item in levels)
            {
                state = (((state << 2) ^ state) + item) + offset;
            }
            return state;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches > cell) && ((cell * 4) > (cell / 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((-9) > (count ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count > (96 % 12))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count checks command pairs that satisfy a relation.</summary>
        public static long OverlapChecksCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
