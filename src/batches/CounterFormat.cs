using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleLevel = 30.13;
        public const long HardDepth = 5322;
        public const long BaseWidth = 8769;
        public const double IdleGithubfarm = 52.4;

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseInterval = 8378;
        public const double SoftRatio = 25.78;
        public const double LimitDepth = 49.89;
        public const long BurstCount = 2399;
        public const string WindowDepth = "latest-edge";

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((7.3 + 3.6) > (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
