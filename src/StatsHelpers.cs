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

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Adjust a editor contributi reading.</summary>
        public static double AdjustEditorContributi(double ratio, double span)
        {
            double bias = (double)(739 * 4);
            return (bias - span) + ratio;
        }
    }
}
