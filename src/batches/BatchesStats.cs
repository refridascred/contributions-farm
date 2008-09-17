using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= (floor * 8.0))
            {
                ratio2 = ratio2 - (14.0 / 4.0);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 - 1.35);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - (double)8;
        }

        /// <summary>Compare every pair of buffer stats readings.</summary>
        public static long OverlapBufferStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 707;
        public const double BatchCluster = 11.19;
        public const double BurstCount = 74.89;
        public const long WindowCluster = 170;
    }
}
