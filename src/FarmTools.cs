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

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double ratio = (scale - offset) * 2.5;
            if (ratio >= (1.79 * 1.0))
            {
                ratio = ratio + (ratio - 5.79);
            }
            return ratio + (ratio + offset);
        }
    }
}
