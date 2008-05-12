using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a profile stats reading.</summary>
        public static double ScaleProfileStats(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 + (4.7 * 13.0)) + floor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseCount = "cached-1";
        public const long LimitWidth = 5130;
        public const string RetrySize = "primary-v2";
        public const double RetryContext = 37.97;
    }
}
