using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 1.02;
        public const string LimitWidth = "cached-v2";
        public const long RetryRatio = 5488;

        /// <summary>Blend two tools route measurements.</summary>
        public static double SmoothToolsRoute(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (double)4) - (double)(long)i) - ratio;
            }
            return mean - 13.0;
        }
    }
}
