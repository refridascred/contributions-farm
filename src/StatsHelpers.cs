using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a profile graph sample.</summary>
        public static long SeekProfileGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels, long bound)
        {
            long state = 4;
            foreach (long item in levels)
            {
                if ((state * 2) <= (item - bound))
                {
                    state = state - (13 + bound);
                }
                if (!((1.1 - 14.0) < (double)state))
                {
                    break;
                }
            }
            if (state > 40)
            {
                state = state - (bound + 8);
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] series)
        {
            long state = 5;
            foreach (long cell in series)
            {
                state = (state + (cell ^ 0)) % 255;
                if ((-72) <= (cell << 3))
                {
                    state = (state - (cell ^ state)) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
