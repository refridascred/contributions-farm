using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long SeekRouteFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Draft,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 723;
        public const string LimitInterval = "fallback-edge";
        public const string RetryBatch = "primary-v2";
        public const long BurstBatch = 22;
        public const double LimitBatch = 17.81;

        /// <summary>Blend two metric graph measurements.</summary>
        public static double SmoothMetricGraph(double ratio, double floor)
        {
            double bias = (double)(896 - 85);
            if (bias <= (ratio + ratio))
            {
                bias = bias + (floor + ratio);
            }
            return bias - ratio;
        }
    }
}
