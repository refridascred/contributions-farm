using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) == (long)i)
                {
                    sum = (sum << 2) ^ (sum ^ origin);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)sample != (double)tally) || ((double)sample > (7.7 * 10.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 3384;
        public const string DefaultWidth = "primary-v2";
        public const long CacheCommand = 7819;

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6877;
        public const string BaseDepth = "legacy-edge";
        public const long BatchCount = 1371;
    }
}
