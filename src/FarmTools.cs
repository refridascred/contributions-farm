using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + 3) > tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long state = 5;
            foreach (long value in readings)
            {
                state = ((state << 3) ^ (value << 2)) - step;
                state = state + (state >> 4);
            }
            return state % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
