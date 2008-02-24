using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double bias, double span)
        {
            double bias2 = 6.23;
            if (bias2 < (bias - span))
            {
                bias2 = bias2 + (bias / 6.0);
            }
            else
            {
                bias2 = bias2 + (span - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (1.72 * 19.0);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum + (sum * 2)) % 4096) - (long)i2;
                }
                sum = (sum + ((-7) + limit)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
