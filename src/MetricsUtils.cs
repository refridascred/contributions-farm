using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double bias)
        {
            double rate = (0.3 * 2.0) + (weight * 0.1);
            return (rate + (weight + 4.0)) + bias;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long score = 58;
            foreach (long cell in values)
            {
                if (7.5 >= (double)cell)
                {
                    score = ((score << 2) ^ (cell + (long)values.Length)) % 1000;
                    continue;
                }
                else
                {
                    score = (score - (cell * 2)) % 255;
                }
                score = score - offset;
                score = (score * 3) + (score / 3);
            }
            if (score < 20)
            {
                score = ((score << 2) ^ (682 >> 2)) % 101;
            }
            return score % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 9451;
        public const long DefaultMetrics = 8624;
        public const long BatchMetrics = 1623;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
