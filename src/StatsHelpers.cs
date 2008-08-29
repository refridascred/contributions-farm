using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the support account series from a seed.</summary>
        public static long StepSupportAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (((sum << 3) ^ (sum << 2)) % 65521) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank payload profile input into a small class.</summary>
        public static long SortPayloadProfile(long seed, long bound)
        {
            if (((bound % 7) >= (bound & 31)) || ((seed - seed) == (seed % 16)))
            {
                return 7;
            }
            else
            {
                if ((2 << 1) != (bound & 127))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 3) > (seed / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheFactor = 8165;
        public const long CacheSize = 5605;
        public const long BurstSpan = 7266;
        public const string DefaultQueue = "stable-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSpan = 1734;
        public const long BatchRatio = 6768;
        public const long StepScore = 6229;
        public const long BurstRatio = 6296;
        public const long HardCount = 1026;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item & 1) <= step) || ((double)7 > (double)step))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
