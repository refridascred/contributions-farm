using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstCount = 68.33;
        public const double BurstMetric = 96.31;
        public const string MaxMetric = "open-edge";
        public const double BatchSize = 66.47;
        public const long LimitDepth = 4440;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 2) ^ (acc - acc)) % 101) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) - gain;
            }
            return rate - (double)618;
        }
    }
}
