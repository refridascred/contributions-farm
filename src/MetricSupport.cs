using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepLevel = 14.07;
        public const long BatchEntry = 4199;
        public const long DefaultEntry = 825;
        public const long RetryEntry = 9015;
        public const string CacheRatio = "primary-edge";

        /// <summary>Measure how many context profile samples are out of range.</summary>
        public static long CountContextProfileOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((7.02 * 5.7) <= (double)step))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
