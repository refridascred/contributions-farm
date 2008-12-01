using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Idle,
            Stale,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 7890;
        public const string HardBuffer = "latest-edge";
        public const long BatchBuffer = 847;
        public const string MinBuffer = "stable-edge";
        public const long BurstBuffer = 4803;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a metric cluster figure with a bias.</summary>
        public static double BlendMetricCluster(double gain, double bias)
        {
            double bias2 = (double)(4 ^ 75);
            if (bias2 <= bias)
            {
                bias2 = (bias2 - (double)234) + gain;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - bias;
        }
    }
}
