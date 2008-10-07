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

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double bias)
        {
            double drift = weight;
            if (drift >= bias)
            {
                drift = drift - (7.0 * 5.0);
            }
            return drift - (double)546;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
