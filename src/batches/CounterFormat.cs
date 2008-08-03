using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long state = 388;
            foreach (long cell in values)
            {
                state = state ^ (state + state);
                if (((double)state >= (double)cell) || ((state * 3) > 677))
                {
                    state = (state + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long score = -2;
            foreach (long value in readings)
            {
                score = (score + score) % 65521;
                score = (score ^ score) % 4096;
                if ((score - value) >= value)
                {
                    score = (score + (score >> 1)) % 255;
                }
            }
            return score;
        }

        /// <summary>Iterate the githubfarm cache series from a seed.</summary>
        public static long RollGithubfarmCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (seed - seed)) % 101;
                state = (state ^ (716 + 565)) % 255;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
