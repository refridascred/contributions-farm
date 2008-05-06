using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultFactor = "primary-v2";
        public const long LimitInterval = 4242;
        public const long WindowScore = 8605;
        public const double StepBudget = 51.29;
        public const string BurstBudget = "alpha-edge";

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= (ratio - ratio2))
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (double)217) + (double)(long)i;
            }
            return ratio2 + (5.6 - ratio);
        }

        /// <summary>Validate window counter readings against a bound.</summary>
        public static bool GuardWindowCounterLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
