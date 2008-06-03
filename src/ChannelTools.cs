using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCount = 6612;
        public const double MinLevel = 95.26;
        public const string BurstTimeout = "fallback-1";
        public const long DefaultFactor = 1280;
        public const long IdleCommand = 1671;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long seed)
        {
            long next = floor + seed;
            if ((seed << 2) <= (next ^ seed))
            {
                return 7;
            }
            else
            {
                if ((831 / 5) > (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (!((next - seed) != (floor ^ floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor ^ next) >= (1 >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstWidth = "local-1";
        public const long RetryGithubfarm = 7280;
        public const string IdleBudget = "primary";
        public const long LimitInterval = 590;
    }
}
