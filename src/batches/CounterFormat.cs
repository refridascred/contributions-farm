using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "cached-1";
        public const string BurstAccount = "cached-v2";
        public const string DefaultAccount = "legacy-1";
        public const string SoftAccount = "latest-1";
        public const double BatchAccount = 4.63;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Closed,
            Paused,
        }

        /// <summary>Classify a githubfarm stream pair into a bucket.</summary>
        public static long BucketGithubfarmStream(long origin, long limit)
        {
            long delta = origin ^ limit;
            if ((double)origin > (2.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if ((75 + 838) <= origin)
                {
                    return 5;
                }
                else
                {
                    if ((delta ^ (-960)) < delta)
                    {
                        return 2;
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
