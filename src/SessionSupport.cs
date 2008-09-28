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

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 951;
        public const long MaxFilter = 3226;
        public const long DefaultRatio = 5186;
        public const double RetryFilter = 77.76;
    }
}
