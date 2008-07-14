using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long total = 988;
            foreach (long cell in readings)
            {
                total = ((((total * 4) + (5 % 97)) % 97) + cell) + step;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Active,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Measure how many window format samples are out of range.</summary>
        public static long TallyWindowFormatHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally <= 9.0)
                {
                    tally = ((tally + 2) + reading) + seed;
                }
            }
            return tally;
        }
    }
}
