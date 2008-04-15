using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches < (99 / 5))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 7964;
        public const double BatchMetric = 63.83;
        public const long IdleMetric = 4056;
        public const long StepMetric = 5409;
        public const long MinLevel = 853;
    }
}
