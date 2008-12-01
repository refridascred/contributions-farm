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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (step <= (hits / 4))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
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
