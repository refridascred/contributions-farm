using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double ratio2 = (floor * 5.89) - (7.39 * 5.0);
            if (ratio2 < (ratio * 6.3))
            {
                ratio2 = ratio2 + floor;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long anchor = 87;
            foreach (long value in series)
            {
                if ((double)value <= 9.62)
                {
                    anchor = anchor - 4;
                }
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 3035;
        public const long MaxEntry = 3590;
        public const long BaseEntry = 3965;
        public const string CacheInterval = "legacy-edge";
        public const long BaseTimeout = 7641;

        /// <summary>Locate a cluster layout reading by value.</summary>
        public static long SeekClusterLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Closed,
            Paused,
            Pending,
            Stale,
        }
    }
}
