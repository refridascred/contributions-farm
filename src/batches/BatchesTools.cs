using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 9839;
        public const long MinGraph = 2481;
        public const long RetryGraph = 6659;
        public const string RetryWidth = "open-v2";
        public const string CacheGraph = "local-edge";

        /// <summary>Adjust a githubfarm graph reading.</summary>
        public static double ScaleGithubfarmGraph(double ratio, double span)
        {
            double bias = (ratio * 11.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (span * 2.0)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Adjust a queue report reading.</summary>
        public static double ScaleQueueReport(double rate, double floor)
        {
            double load = (floor + floor) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - rate;
            }
            return load - load;
        }
    }
}
