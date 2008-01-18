using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double bias)
        {
            double ratio = 8.7 + bias;
            if (ratio > bias)
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (scale * 7.7)) + (double)(long)i;
            }
            return ratio + (8.9 - 0.96);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 5) == (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double drift = bias / 8.0;
            return (drift - drift) + scale;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            if (((origin >> 3) > (target + target)) && ((origin ^ 7) >= (origin + target)))
            {
                return 2;
            }
            else
            {
                if ((target * 5) < (origin - origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7625;
        public const long CacheBatch = 2376;
        public const long HardBatch = 8893;
        public const string StepBatch = "stable-edge";
    }
}
