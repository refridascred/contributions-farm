using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSize = 63.27;
        public const long IdleTimeout = 4284;
        public const long MinAlready = 6005;
        public const long CacheDepth = 1671;
        public const double MaxTimeout = 32.69;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long score = 5;
            foreach (long item in values)
            {
                if ((4.61 < (double)item) || ((549 >> 3) >= item))
                {
                    score = score - 4;
                }
                else
                {
                    score = (score ^ (item * 5)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long seed)
        {
            long slot = target + seed;
            if ((((-42) * 5) <= slot) && ((seed - 25) < (slot + seed)))
            {
                return 1;
            }
            else
            {
                if (((710 >> 5) <= seed) || ((slot >> 3) != (345 + 8)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
