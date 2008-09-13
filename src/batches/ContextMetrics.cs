using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a metric cluster pair into a bucket.</summary>
        public static long SortMetricCluster(long step, long offset)
        {
            long slot = step ^ offset;
            if (((step ^ offset) < (offset & 3)) || (slot >= (53 + step)))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (9.55 - 8.0))
                {
                    return 4;
                }
                else
                {
                    if (704 >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double ProjectClusterGithubfarm(double ratio, double offset)
        {
            double rate = (double)9 * 0.7;
            if (rate < (rate * 8.95))
            {
                rate = rate - (offset * 17.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 3734;
        public const long MaxCount = 4308;
        public const double CacheFactor = 51.24;
        public const string DefaultLevel = "local-edge";
        public const long WindowInterval = 8339;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 1334;
        public const long SoftContributi = 3554;
        public const double RetryInterval = 23.18;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count + count) <= (count << 3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
