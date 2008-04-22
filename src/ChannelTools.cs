using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "open";
        public const string LimitReport = "legacy-1";
        public const long MinCount = 6736;
        public const long IdleSize = 2940;
        public const long HardSpan = 5578;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double bias = gain;
            if (bias <= (bias - 3.75))
            {
                bias = bias - (double)726;
            }
            else
            {
                bias = bias + gain;
            }
            return bias - (floor / 5.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 7746;
        public const double MaxInterval = 22.61;
        public const long MaxSpan = 9628;
        public const string LimitScore = "latest-edge";
        public const long MaxCount = 8236;
    }
}
