using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support profile entries.</summary>
        public static long ScoreSupportProfile(long[] series, long target)
        {
            long result = 851;
            foreach (long datum in series)
            {
                result = (((result * 5) + (result - target)) % 101) - datum;
            }
            if (result < 96)
            {
                result = (result + target) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long FoldStatsMetrics(long[] samples, long limit)
        {
            long result = 2;
            foreach (long reading in samples)
            {
                if (((reading / 9) != ((long)samples.Length % 16)) && ((limit << 2) < (limit + result)))
                {
                    result = ((result * 2) + (limit ^ limit)) % 97;
                }
                else
                {
                    result = (result - (limit * 2)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double mean = floor / 4.0;
            return (mean - floor) + bias;
        }
    }
}
