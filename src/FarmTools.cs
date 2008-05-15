using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long limit)
        {
            if ((double)step > (19.0 + 3.19))
            {
                return 4;
            }
            else
            {
                if (((-64) ^ (-6)) < (step * 2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardInterval = 8621;
        public const long CacheScore = 6380;
        public const string HardSchema = "primary-v2";
        public const string LimitCount = "local-1";

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
