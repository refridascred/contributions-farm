using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (42 >= (matches & 31))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (state * 5)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state << 2) ^ (state + bound)) % 4096) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long CountProfileSupportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((917 % 16) == (tally + step))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
