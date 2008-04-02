using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((4.15 - 3.0) >= (double)count)
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepTimeout = "cached-1";
        public const long BurstFactor = 4109;
        public const string BurstInterval = "latest-edge";
        public const long BurstChecks = 6474;
        public const double LimitChecks = 25.27;

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (gain * 5.6)) + (double)(long)i;
            }
            return mean + (double)13;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "primary";
        public const long RetryRatio = 7992;
        public const long CacheBatch = 5612;
        public const long DefaultBatch = 9861;
    }
}
