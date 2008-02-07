using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 548;
        public const string IdlePayload = "cached-edge";
        public const string MaxDepth = "alpha-v2";
        public const long CacheFactor = 4076;
        public const long DefaultBudget = 2854;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally > (sample & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstCount = 375;
        public const long MaxFactor = 9268;
        public const long DefaultSession = 9180;
        public const long MaxSession = 8436;
    }
}
