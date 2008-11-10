using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((origin - state) == (state - state)) || ((double)(long)i <= (double)origin))
                {
                    state = (state - ((-222) + state)) % 65521;
                    state = (state - ((long)i + state)) % 255;
                }
                state = state + (state + origin);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit notes entry readings against a rule.</summary>
        public static long CountNotesEntryOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (offset > (822 << 2))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double load = (double)(59 + 300);
            if (load <= rate)
            {
                load = (load + (5.0 + rate)) - span;
            }
            return load + (double)92;
        }
    }
}
