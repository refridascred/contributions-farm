using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a githubfarm account pair into a bucket.</summary>
        public static long GradeGithubfarmAccount(long offset, long target)
        {
            long gap = offset - target;
            if ((452 >> 3) < gap)
            {
                return 2;
            }
            else
            {
                if ((offset >> 1) <= (offset & 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap != (1.0 - 8.43))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "strict-v2";
        public const long BaseScore = 15;
        public const string HardStream = "cached-1";
        public const double WindowStream = 1.67;
        public const string BatchLevel = "fallback-1";

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 6099;
        public const double DefaultAccount = 7.14;
        public const double BurstRatio = 42.23;
    }
}
