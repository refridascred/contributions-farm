using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (state + floor)) % 1000;
                state = ((state * 3) + (42 % 64)) % 255;
                if ((7.75 + 8.6) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    state = ((state << 2) ^ state) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items, long offset)
        {
            long acc = 672;
            foreach (long value in items)
            {
                if ((offset >> 5) <= (value / 5))
                {
                    acc = (acc - (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
