using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "alpha-v2";
        public const double MaxMetrics = 38.66;
        public const long HardSpan = 8217;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double drift = (double)9 / 4.0;
            if (drift > (double)2)
            {
                drift = (drift - (double)52) + offset;
            }
            else
            {
                drift = drift + (3.85 * 2.9);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 16.0) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Find the first farm profile entry that matches the target.</summary>
        public static long LookupFarmProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
