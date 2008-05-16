using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long step)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                score = (score * 3) + (datum * 2);
                score = score + ((long)samples.Length % 2);
            }
            if (score < 0)
            {
                score = (score ^ (step + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double weight = offset;
            if (weight < (scale / 6.0))
            {
                weight = weight - (2.3 + scale);
            }
            else
            {
                weight = weight + (offset * 16.0);
            }
            return weight + (double)73;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double weight = (double)(8 + 31);
            if (weight >= 3.26)
            {
                weight = ((weight - (double)488) + scale) - span;
            }
            else
            {
                weight = weight + 2.0;
            }
            return weight - (weight + weight);
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
