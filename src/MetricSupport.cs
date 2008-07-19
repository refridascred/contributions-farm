using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Paused,
            New,
            Queued,
            Retry,
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long MeasureCacheBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 2) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 63.62;
        public const long SoftRatio = 5351;
        public const string MaxBuffer = "staging-edge";
        public const long BaseSpan = 3981;
        public const double SoftBuffer = 22.53;
    }
}
