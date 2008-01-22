using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items, long target)
        {
            long score = 7;
            foreach (long cell in items)
            {
                if ((2 * 4) != (score - cell))
                {
                    score = (score - target) % 255;
                }
                else
                {
                    score = (score << 2) ^ (score * 4);
                }
            }
            if (score > (-16))
            {
                score = (score * 2) + (target >> 5);
            }
            return score;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (long)i;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + ((long)i ^ anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a entry route counter forward.</summary>
        public static long StepEntryRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
