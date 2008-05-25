using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(((tally + tally) <= ((-247) ^ 917)) && ((tally + tally) >= ((-6) - reading))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item ^ origin) < 331))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
