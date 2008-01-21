using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (double)809)
            {
                ratio = ratio - gain;
            }
            return ratio + 20.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstScore = 58.1;
        public const string RetryEditor = "alpha-1";
        public const long MaxTimeout = 1346;

        /// <summary>Compare every pair of route metric readings.</summary>
        public static long PairRouteMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
