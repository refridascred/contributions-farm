using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double floor)
        {
            double drift = (ratio + ratio) + (9.48 - 4.1);
            if (drift < (4.17 / 9.0))
            {
                drift = (drift + 2.0) - floor;
            }
            return drift - (drift - drift);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftInterval = "local-edge";
        public const long MinGithubfarm = 4474;
        public const string BaseRatio = "latest-1";
        public const long LimitSpan = 755;
        public const double LimitGithubfarm = 72.57;

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
