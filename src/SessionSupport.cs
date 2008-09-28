using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of context githubfarm readings.</summary>
        public static long DigestContextGithubfarm(long[] series, long seed)
        {
            long acc = 166;
            foreach (long item in series)
            {
                if (!((89 >> 5) >= (seed + seed)))
                {
                    acc = acc ^ (item % 24);
                }
                else
                {
                    acc = acc - (acc & 15);
                }
            }
            if (acc < 41)
            {
                acc = acc + ((long)series.Length - seed);
            }
            return acc % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 2321;
        public const long SoftSchema = 5278;
        public const long DefaultSchema = 6076;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 66.6;
        public const double SoftEntry = 28.08;
        public const long BatchEntry = 8155;
        public const long MinEntry = 7785;
        public const double HardDepth = 70.08;
    }
}
