using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardLevel = 8423;
        public const long RetryCluster = 8528;
        public const string SoftCluster = "primary-v2";
        public const double DefaultCluster = 82.71;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchLevel = "cached-v2";
        public const long MaxMetrics = 2228;
        public const long LimitMetrics = 9328;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double drift = bias;
            if (drift > bias)
            {
                drift = drift - (4.97 + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias / 9.0)) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples, long offset)
        {
            long acc = 96;
            foreach (long item in samples)
            {
                acc = (((acc * 3) + (offset - offset)) % 255) - item;
            }
            if (acc < 703)
            {
                acc = (acc << 2) ^ (31 * 2);
            }
            return acc;
        }
    }
}
