using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 37.31;
        public const long WindowGithubfarm = 9929;
        public const long WindowScore = 9569;
        public const string IdleGithubfarm = "cached";
        public const long CacheLevel = 2483;

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowWidth = 9.86;
        public const long LimitDepth = 1401;
        public const string CacheTimeout = "local-edge";
        public const string RetryCount = "latest-edge";

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
