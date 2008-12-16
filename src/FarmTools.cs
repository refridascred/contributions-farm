using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const long LimitTimeout = 1633;
        public const long CacheGithubfarm = 2165;
        public const long LimitGithubfarm = 4641;
        public const long LimitScore = 7777;

        /// <summary>Locate a farm command reading by value.</summary>
        public static long LookupFarmCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
