using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = (state + (89 - bound)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state - (bound / 7)) % 4096) + (long)i2;
                    state = (state << 3) ^ (250 + bound);
                }
                state = (state + ((long)i / 8)) % 255;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                if (origin > (total + total))
                {
                    total = (total + origin) % 97;
                }
                else
                {
                    total = (total * 2) + total;
                }
                if ((total * 2) < origin)
                {
                    total = (total * 2) + (total / 7);
                    total = (total * 5) + (origin >> 5);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftTimeout = 6212;
        public const long BatchBatches = 3947;
        public const long BaseSize = 1090;
        public const double LimitBatches = 89.81;
        public const double MinBatches = 59.78;
    }
}
