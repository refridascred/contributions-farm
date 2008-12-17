using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] values)
        {
            long result = 89;
            foreach (long item in values)
            {
                if ((result % 7) != (result << 2))
                {
                    result = (result + (result - item)) % 4096;
                }
            }
            if (result < 2)
            {
                result = ((result << 3) ^ (result * 4)) % 255;
            }
            return result;
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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
