using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 10.78;
        public const long BatchTimeout = 5133;
        public const string BurstBudget = "latest-1";
        public const long WindowCount = 7437;
        public const long WindowBudget = 5751;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double mean = offset;
            if (mean > (scale * 9.8))
            {
                mean = mean - (scale / 5.0);
            }
            else
            {
                mean = mean + (double)185;
            }
            return mean + offset;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
