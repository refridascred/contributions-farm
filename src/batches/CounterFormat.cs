using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ tally) == (long)levels.Length)
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

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 53.45;
        public const long SoftLayout = 7989;
        public const string BurstLayout = "latest-1";
        public const long WindowCount = 2658;
    }
}
