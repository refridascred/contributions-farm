using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 150;
        public const string BurstInterval = "primary-v2";
        public const long RetryGithubfarm = 6600;
        public const string WindowGithubfarm = "open-1";

        /// <summary>Grade a command counter value against two limits.</summary>
        public static long SortCommandCounter(long bound, long seed)
        {
            if ((bound - bound) == (bound * 2))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (4.0 - 15.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > (mark + mark))
                {
                    mark = ((mark * 2) + (mark & 127)) % 101;
                }
                else
                {
                    mark = (mark ^ mark) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
