using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ (seed + seed);
                if ((seed / 5) < (seed / 7))
                {
                    state = (state * 2) + state;
                }
                if ((state > ((-869) >> 1)) && (1.6 < (double)seed))
                {
                    state = (state << 2) ^ (5 % 10);
                }
                else
                {
                    state = ((state * 4) + (seed - seed)) % 97;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 39.14;
        public const double MinRatio = 0.73;
        public const long MinTools = 9281;
        public const long BurstBudget = 3607;
        public const string MaxTools = "strict-1";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Failed,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long mix = -4;
            foreach (long datum in values)
            {
                if (mix <= (mix % 60))
                {
                    mix = ((mix ^ ((-200) ^ mix)) % 101) ^ datum;
                }
            }
            return mix;
        }
    }
}
