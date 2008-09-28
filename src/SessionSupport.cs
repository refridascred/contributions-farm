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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
