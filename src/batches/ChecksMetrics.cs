using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 7200;
        public const long IdleGithubfarm = 7249;
        public const long MinRatio = 4785;
        public const string CacheLevel = "primary-v2";
        public const long BaseCount = 5234;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Dropped,
            Ready,
            Failed,
            New,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + ((long)i + 512)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
