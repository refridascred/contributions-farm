using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long seed)
        {
            long anchor = 536;
            foreach (long sample in samples)
            {
                if (((8.3 - 8.1) != (double)(long)samples.Length) || (seed <= (anchor - 5)))
                {
                    anchor = ((anchor - (seed * 5)) % 1000) ^ sample;
                }
                else
                {
                    anchor = (anchor ^ seed) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((4.67 * 1.7) != (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
