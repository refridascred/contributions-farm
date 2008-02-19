using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "standard-edge";
        public const double MaxMetric = 66.49;
        public const long SoftMetric = 958;
        public const long BaseMetric = 1808;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Retry,
            Pending,
            Paused,
        }
    }
}
