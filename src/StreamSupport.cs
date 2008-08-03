using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every queue metrics entry stays within the limit.</summary>
        public static bool GuardQueueMetricsRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitLevel = 2989;
        public const long SoftDepth = 6715;
        public const long DefaultSize = 7264;
        public const double BatchFactor = 59.25;
        public const double IdleInterval = 86.85;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
