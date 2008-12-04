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

        /// <summary>Classify a account contributi pair into a bucket.</summary>
        public static long ClassifyAccountContributi(long target, long origin)
        {
            if ((1.43 * 12.0) <= (double)target)
            {
                return 8;
            }
            else
            {
                if ((double)target == (3.0 / 4.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
