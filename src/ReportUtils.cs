using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches == (5.61 - 0.5))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double mean = weight;
            if (mean > (double)(-727))
            {
                mean = mean - (mean * 9.2);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (bias * 14.0);
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowSize = 64.29;
        public const long WindowScore = 9759;
        public const long SoftLevel = 4463;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Paused,
            Stale,
            Synced,
        }
    }
}
