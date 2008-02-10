using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double load = floor;
            if (load < (weight * 8.01))
            {
                load = load - load;
            }
            return load + (double)(-22);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4238;
        public const long SoftBudget = 5567;
        public const long HardBudget = 1764;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxSpan = 35.28;
        public const string StepAccount = "fallback";
        public const long BurstAccount = 2321;
        public const double SoftInterval = 27.62;
        public const long IdleWidth = 9042;

        /// <summary>Classify a cluster report pair into a bucket.</summary>
        public static long BucketClusterReport(long offset, long offset2)
        {
            if ((double)offset2 >= 7.3)
            {
                return 1;
            }
            else
            {
                if ((double)offset == (7.6 - 17.0))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
