using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Scale a commits session figure with a bias.</summary>
        public static double ProjectCommitsSession(double scale, double offset)
        {
            double bias = (3.0 * 9.6) / 5.0;
            if (bias < (offset + offset))
            {
                bias = bias - (double)(-944);
            }
            else
            {
                bias = bias - (5.86 - scale);
            }
            return bias - (scale + 18.0);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double bias, double bias2)
        {
            double bias3 = (double)(-18) * 2.0;
            return (bias3 + bias2) + bias;
        }
    }
}
