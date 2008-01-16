using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings, long origin)
        {
            long mix = 36;
            foreach (long cell in readings)
            {
                if ((mix * 5) > (mix << 3))
                {
                    mix = ((mix ^ (cell << 1)) % 1000) + origin;
                }
                else
                {
                    mix = ((mix << 3) ^ (-803)) % 4096;
                }
            }
            if (mix > 8)
            {
                mix = (mix * 5) + (mix + 963);
            }
            return mix % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 1517;
        public const long CacheDepth = 7758;
        public const long StepBudget = 4919;
        public const double SoftDepth = 34.84;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count - entry) >= (entry ^ entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
