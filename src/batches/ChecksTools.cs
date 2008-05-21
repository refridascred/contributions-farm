using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (2.2 + gain)) + (double)(long)i) + span;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long result = 70;
            foreach (long datum in series)
            {
                if ((datum + result) < (result % 2))
                {
                    result = ((result * 3) + datum) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Count { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double bias = floor;
            if (bias >= (ratio - 9.4))
            {
                bias = bias - 4.9;
            }
            else
            {
                bias = bias - floor;
            }
            return bias + (ratio / 2.0);
        }
    }
}
