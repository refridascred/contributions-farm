using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (5.82 + bias))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (double)764;
            }
            return scale2 - (double)242;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryWidth = 0.6;
        public const string BaseStream = "latest-edge";
        public const string StepStream = "legacy-v2";
        public const long BatchStream = 6821;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Paused,
            Done,
            Closed,
        }
    }
}
