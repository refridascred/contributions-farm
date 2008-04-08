using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double floor)
        {
            double gain = (double)(56 ^ (-14));
            if (gain > (double)6)
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain - (gain + gain);
            }
            return gain + (scale - scale);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitLevel = 4459;
        public const string StepTimeout = "alpha-edge";
        public const long IdleAccount = 5310;
        public const string SoftAccount = "fallback";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
