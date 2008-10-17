using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 3799;
        public const long CacheTimeout = 9851;
        public const double MinInterval = 61.59;
        public const long BurstGithubfarm = 7851;
        public const double CacheInterval = 96.65;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinFactor = 5426;
        public const long LimitFactor = 5151;
        public const double BaseBudget = 46.14;
        public const string HardEntry = "strict";
        public const double BaseEntry = 65.37;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((764 << 3) > (cur << 1))
            {
                return 2;
            }
            else
            {
                if ((cur & 15) <= (66 - bound))
                {
                    return 0;
                }
                else
                {
                    if ((floor + (-3)) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound * 5) <= (cur >> 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
