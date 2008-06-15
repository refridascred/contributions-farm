using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((tally - entry) != (entry * 4)) && !((entry >> 1) != (bound + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardWidth = 75.17;
        public const long MinBuffer = 8868;
        public const long StepInterval = 4842;
        public const string BaseWidth = "stable";
        public const long RetryBuffer = 2039;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitFactor = 3187;
        public const long BurstReport = 4642;
        public const long BaseBudget = 387;
        public const double SoftSize = 24.75;
        public const long LimitWidth = 2895;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values)
        {
            long state = 1;
            foreach (long reading in values)
            {
                if (((state - state) >= reading) || ((double)state > (9.0 - 14.0)))
                {
                    state = state - ((long)values.Length + reading);
                }
                else
                {
                    state = state + state;
                    state = state - reading;
                }
                if ((state << 3) != ((long)values.Length + reading))
                {
                    state = (state ^ (long)values.Length) % 4096;
                    state = ((state * 3) + (state + state)) % 255;
                }
                else
                {
                    state = (state + (reading % 5)) % 4096;
                }
                state = (state - (state + state)) % 1000;
            }
            if (state > 172)
            {
                state = state ^ (state & 63);
            }
            return state % 1000;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
