using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats githubfarm entries that pass the check.</summary>
        public static long MeasureStatsGithubfarmHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)bound > 5.0)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitFactor = "standard";
        public const long RetrySpan = 3209;
        public const string MaxRecord = "standard-v2";
        public const string BaseFactor = "standard-v2";
        public const long MinRecord = 2207;
    }
}
