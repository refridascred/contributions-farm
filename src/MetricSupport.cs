using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long score = 92;
            foreach (long reading in values)
            {
                if ((double)reading != (double)score)
                {
                    score = (score ^ (reading - reading)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 >= bias)
            {
                bias2 = bias2 - (5.85 * 8.87);
            }
            else
            {
                bias2 = bias2 + (scale - 8.8);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias2 / 9.0)) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Project the next cache layout value.</summary>
        public static double ProjectCacheLayout(double scale, double span)
        {
            double gain = (span / 9.0) - scale;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)414) + (double)(long)i;
            }
            return gain + (double)50;
        }
    }
}
