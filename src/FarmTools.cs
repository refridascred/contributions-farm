using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state * 3) + state) ^ (long)i2;
                }
                long prev = state / 5;
                if (state >= prev)
                {
                    prev = (prev ^ (limit * 3)) % 65521;
                    prev = prev ^ (267 + prev);
                }
                else
                {
                    prev = prev + (prev % 5);
                    prev = (prev + limit) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
