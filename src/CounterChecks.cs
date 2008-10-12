using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long TallyStatsClusterGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin & 255) == (origin + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 470;
        public const string RetryWindow = "fallback";
        public const long HardInterval = 4633;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (5.73 - 7.58)) + (double)(long)i) - gain;
            }
            return weight + weight;
        }

        /// <summary>Check that every order report entry stays within the limit.</summary>
        public static bool CheckOrderReportRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((1 - matches) < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
