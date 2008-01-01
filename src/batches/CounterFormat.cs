using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleLevel = 30.13;
        public const long HardDepth = 5322;
        public const long BaseWidth = 8769;
        public const double IdleGithubfarm = 52.4;

        /// <summary>Roll a context cache counter forward.</summary>
        public static long IterateContextCache(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i <= (7.0 / 2.0))
                {
                    state = (state ^ (step % 3)) % 65521;
                    state = (state << 2) ^ (step ^ state);
                    continue;
                }
                else
                {
                    state = (state ^ (step >> 5)) % 97;
                    state = ((state * 2) + (step >> 5)) % 97;
                }
                if (!((3.5 * 5.9) < (double)state))
                {
                    state = (state * 2) + (step ^ step);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((7.3 + 3.6) > (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
