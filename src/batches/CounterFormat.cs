using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((total + 986) > (value + value)) || (total > (total & 127)))
                {
                    total = (total - (total >> 4)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the tools profile entries that pass the check.</summary>
        public static long CountToolsProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + reading) == (matches - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long bound)
        {
            long state = 11;
            foreach (long value in data)
            {
                if (value >= (state * 3))
                {
                    state = (state + (state % 60)) % 65521;
                }
                else
                {
                    state = state - state;
                }
            }
            if (state > 1)
            {
                state = (state * 5) + bound;
            }
            return state % 1000;
        }
    }
}
