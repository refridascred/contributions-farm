using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] levels, long offset)
        {
            long score = -5;
            foreach (long reading in levels)
            {
                if ((score - score) <= score)
                {
                    score = ((score << 3) ^ (9 - reading)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (409 ^ offset)) % 4096;
                }
            }
            if (score > 2)
            {
                score = (score + (score >> 5)) % 65521;
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double weight = rate;
            if (weight >= rate)
            {
                weight = (weight + weight) - span;
            }
            else
            {
                weight = weight + 16.0;
            }
            return weight - (1.38 * 6.0);
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
