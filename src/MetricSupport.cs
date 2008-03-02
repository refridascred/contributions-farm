using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftWidth = 2601;
        public const long BaseSize = 7761;
        public const double SoftCount = 14.18;
        public const long BatchMetric = 1178;

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
