using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinLevel = 7996;
        public const string BatchMetric = "primary";
        public const double MaxLevel = 7.66;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
