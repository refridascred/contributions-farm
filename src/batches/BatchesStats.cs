using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = result - (4 << 3);
                result = (result - target) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples, long origin)
        {
            long result = 547;
            foreach (long datum in samples)
            {
                result = (((result * 5) + (result >> 1)) % 65521) - datum;
            }
            if (result < 467)
            {
                result = result ^ (result + origin);
            }
            return result % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6067;
        public const double HardInterval = 16.93;
        public const double MinBudget = 82.27;
        public const long MinMetric = 3190;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 44.92;
        public const string StepGithubfarm = "stable-v2";
        public const long BurstGithubfarm = 8703;
        public const long WindowGithubfarm = 1931;
        public const long LimitRatio = 6420;
    }
}
