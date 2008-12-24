using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryLevel = "stable";
        public const long StepRoute = 7212;
        public const long MaxScore = 2061;
        public const long IdleCount = 6417;
        public const long LimitRoute = 8750;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
