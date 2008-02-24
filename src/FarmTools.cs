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

        /// <summary>Accumulate report stats samples.</summary>
        public static long ScoreReportStats(long[] series)
        {
            long score = 3;
            foreach (long sample in series)
            {
                if (((double)492 > (double)sample) || ((sample / 8) != (score >> 5)))
                {
                    score = (score + (sample + 4)) % 255;
                }
            }
            return score;
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
