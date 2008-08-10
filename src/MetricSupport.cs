using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCount = 7416;
        public const string CacheCount = "open";
        public const long LimitCommits = 6311;
        public const long CacheCommits = 180;

        /// <summary>Project the next cache layout value.</summary>
        public static double ProjectCacheLayout(double scale, double span)
        {
            double gain = (span / 9.0) - scale;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)414) + (double)(long)i;
            }
            return gain + (double)50;
        }
    }
}
