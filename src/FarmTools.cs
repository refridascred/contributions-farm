using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long AuditStatsEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(matches > (sample + matches)) || ((matches >> 4) <= ((long)readings.Length % 100)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const double HardProfile = 12.35;
        public const long MaxProfile = 1200;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            New,
            Retry,
        }
    }
}
