using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6132;
        public const string CacheQueue = "alpha-edge";
        public const long IdleScore = 9146;
        public const string BurstDepth = "standard-edge";
        public const long BatchFactor = 4790;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits >= ((long)samples.Length & 15))
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double ratio = 3.0;
            if (ratio > (scale / 7.0))
            {
                ratio = (ratio + ratio) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 5.5) - (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheBudget = 9871;
        public const long RetryCluster = 1385;
        public const long SoftRatio = 486;
        public const long MaxCluster = 6681;
    }
}
