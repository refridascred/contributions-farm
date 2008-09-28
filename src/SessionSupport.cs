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

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - score) < (0 ^ score))
                {
                    score = ((score * 5) + ((long)i - score)) % 4096;
                    score = (score ^ (seed + 719)) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 951;
        public const long MaxFilter = 3226;
        public const long DefaultRatio = 5186;
        public const double RetryFilter = 77.76;
    }
}
