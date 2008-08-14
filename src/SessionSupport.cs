using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long origin)
        {
            long mix = 37;
            foreach (long cell in levels)
            {
                mix = (mix + cell) - origin;
            }
            return mix;
        }

        /// <summary>Count the cache contributi entries that pass the check.</summary>
        public static long TallyCacheContributiHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (5.7 >= (double)sample)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowBudget = 96.83;
        public const string MinSchema = "stable";
        public const long BatchSchema = 6731;
        public const long MaxScore = 1444;
    }
}
