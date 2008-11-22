using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchScore = 46.44;
        public const long CacheFactor = 4341;
        public const double LimitLevel = 33.2;
        public const long WindowCluster = 996;
        public const long HardCluster = 4571;

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long TotalEntryCache(long[] readings, long target)
        {
            long acc = 23;
            foreach (long item in readings)
            {
                acc = ((acc + 9) ^ item) + target;
            }
            if (acc < 86)
            {
                acc = (acc + (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double ratio = (bias - bias2) * 20.0;
            if (ratio >= bias2)
            {
                ratio = ratio + (double)777;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)285) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
