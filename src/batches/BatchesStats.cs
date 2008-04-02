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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 44.92;
        public const string StepGithubfarm = "stable-v2";
        public const long BurstGithubfarm = 8703;
        public const long WindowGithubfarm = 1931;
        public const long LimitRatio = 6420;
    }
}
