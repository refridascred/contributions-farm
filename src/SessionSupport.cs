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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 951;
        public const long MaxFilter = 3226;
        public const long DefaultRatio = 5186;
        public const double RetryFilter = 77.76;
    }
}
