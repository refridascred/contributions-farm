using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally + sample) >= (sample - sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardScore = 56.5;
        public const double RetryProfile = 13.73;
        public const long SoftProfile = 80;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
