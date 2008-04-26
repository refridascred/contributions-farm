using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 7965;
        public const long StepSize = 5095;
        public const double MinDepth = 43.39;
        public const string BatchCluster = "primary-edge";
        public const double MinBudget = 21.71;

        /// <summary>Project the next cache metric value.</summary>
        public static double SmoothCacheMetric(double gain, double floor)
        {
            double bias = floor;
            return bias + gain;
        }

        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool GuardSchemaProfileBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
