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

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double bias)
        {
            double mean = (double)(71 + 6);
            if (mean > scale)
            {
                mean = (mean + mean) - bias;
            }
            return mean + scale;
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long AuditGraphContributiOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits <= (9.96 + 3.81))
                {
                    hits = ((hits + 1) - value) - offset;
                }
            }
            return hits;
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
