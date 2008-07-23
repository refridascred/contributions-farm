using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSpan = 5566;
        public const string BaseAccount = "standard-edge";
        public const long MinAccount = 3060;
        public const string BaseWidth = "alpha-edge";

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowSize = "latest-v2";
        public const long RetryQueue = 1748;
        public const double LimitQueue = 60.48;
        public const string CacheQueue = "cached-v2";
        public const long SoftQueue = 6578;
    }
}
