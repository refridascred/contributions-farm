using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 827;
        public const long CacheGithubfarm = 4734;
        public const long BatchBudget = 1156;
        public const long DefaultDepth = 2980;
        public const long MaxDepth = 364;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double mean = floor / 7.0;
            return (mean + (double)3) + gain;
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long MeasureClusterQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (14.0 >= (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
