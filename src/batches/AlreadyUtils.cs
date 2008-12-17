using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi cluster measurements.</summary>
        public static double SmoothContributiCluster(double rate, double span)
        {
            double scale = 18.0 - (8.58 / 5.0);
            if (scale <= scale)
            {
                scale = (scale - (rate * 5.7)) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 4.0) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepWidth = "open-edge";
        public const double CacheRatio = 23.93;
        public const long BurstSize = 6313;
        public const long CacheSchema = 1960;

        /// <summary>Blend two command batch measurements.</summary>
        public static double SmoothCommandBatch(double bias, double offset)
        {
            double mean = offset;
            if (mean < (mean - bias))
            {
                mean = mean + (double)8;
            }
            return mean + 9.6;
        }
    }
}
