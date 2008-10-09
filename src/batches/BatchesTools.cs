using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 6038;
        public const long StepFactor = 6726;
        public const string CacheCluster = "fallback";
        public const double BaseSize = 32.29;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a counter cluster reading.</summary>
        public static double AdjustCounterCluster(double gain, double span)
        {
            double drift = 2.47;
            if (drift >= (gain - span))
            {
                drift = drift - (double)(-6);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (span + drift)) - (double)(long)i;
            }
            return drift + span;
        }
    }
}
