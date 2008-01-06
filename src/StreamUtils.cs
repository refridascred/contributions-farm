using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a cluster metrics figure with a bias.</summary>
        public static double AdjustClusterMetrics(double gain, double bias)
        {
            double weight = (double)(8 - 3);
            if (weight < gain)
            {
                weight = weight + (9.6 - bias);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (8.4 + 13.0)) - (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double gain = 1.0 / 5.0;
            return (gain + (rate / 7.0)) + bias;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            New,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long AuditToolsStatsGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits < 9.0)
                {
                    hits = ((hits + 3) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstInterval = 2995;
        public const string WindowBudget = "latest-v2";
        public const long BatchBudget = 2320;
        public const string DefaultStats = "local";
        public const long BurstScore = 5830;
    }
}
