using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 98.17;
        public const long BurstBudget = 8338;
        public const double MinScore = 70.89;

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 67;
            foreach (long sample in items)
            {
                anchor = anchor - sample;
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double scale = span * 4.88;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - (scale * 1.9)) + (double)(long)i) + bias;
            }
            return scale + (span - 2.0);
        }
    }
}
