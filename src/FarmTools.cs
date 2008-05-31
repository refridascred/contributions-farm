using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((131 <= ((long)values.Length + reading)) || ((double)872 <= (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)count < (5.1 * 8.0)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
