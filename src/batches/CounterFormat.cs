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

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long carry = -238;
            foreach (long cell in data)
            {
                if ((cell % 8) > (carry + carry))
                {
                    carry = ((carry * 4) + (cell + cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item ^ 95) == (item + item)) && (((72 >> 5) != (floor ^ tally)) || ((tally % 60) >= item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
