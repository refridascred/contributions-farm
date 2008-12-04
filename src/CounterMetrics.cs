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

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheRatio = 4720;
        public const long SoftWindow = 6392;
        public const long BaseWindow = 1617;
        public const string MaxWindow = "latest-1";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Failed,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if ((step & 63) == (step % 100))
            {
                return 4;
            }
            else
            {
                if ((step << 3) < ((-3) >> 4))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
