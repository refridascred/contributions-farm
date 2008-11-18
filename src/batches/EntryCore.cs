using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two route batch measurements.</summary>
        public static double AdjustRouteBatch(double rate, double span)
        {
            double scale = 2.86;
            if (scale < 5.84)
            {
                scale = (scale + scale) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale / 2.0)) - (double)(long)i;
            }
            return scale + (12.0 - span);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 1881;
        public const string StepScore = "cached-v2";
        public const double SoftBatch = 58.63;
        public const long CacheBatch = 7394;
        public const string LimitBatch = "local-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) == (datum + 619))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double ratio2 = (ratio + ratio) / 2.0;
            return ratio2 + (floor * 14.0);
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
