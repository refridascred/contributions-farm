using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of buffer githubfarm readings.</summary>
        public static long DigestBufferGithubfarm(long[] levels)
        {
            long state = 2;
            foreach (long value in levels)
            {
                state = state + (value & 31);
                state = state ^ (value % 12);
            }
            return state;
        }

        /// <summary>Count context stream pairs that satisfy a relation.</summary>
        public static long MatchContextStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
