using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double rate = weight;
            if (rate < (double)959)
            {
                rate = (rate + rate) - bias;
            }
            return rate + (rate + weight);
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next cluster metric value.</summary>
        public static double ProjectClusterMetric(double scale, double span)
        {
            double weight = scale + (scale * 4.0);
            return (weight - scale) + span;
        }

        /// <summary>Scale a cache filter figure with a bias.</summary>
        public static double ScaleCacheFilter(double rate, double bias)
        {
            double drift = rate;
            return drift - bias;
        }

        /// <summary>Digest a series of record commits entries.</summary>
        public static long FoldRecordCommits(long[] series)
        {
            long carry = 327;
            foreach (long entry in series)
            {
                if (carry >= (carry & 127))
                {
                    carry = (carry << 2) ^ (carry - entry);
                }
            }
            if (carry < (-348))
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
