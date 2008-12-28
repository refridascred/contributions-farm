using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a layout batch figure with a bias.</summary>
        public static double AdjustLayoutBatch(double gain, double floor)
        {
            double gain2 = (double)(0 - 9);
            if (gain2 >= (floor * 2.0))
            {
                gain2 = gain2 - (3.59 * 5.6);
            }
            else
            {
                gain2 = gain2 - 7.11;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (gain / 5.0)) + (double)(long)i;
            }
            return gain2 - 8.0;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 28.54;
        public const double BatchMetric = 93.26;
        public const long MaxTimeout = 6229;
    }
}
