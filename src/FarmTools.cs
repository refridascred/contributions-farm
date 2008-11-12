using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many profile commits samples are out of range.</summary>
        public static long AuditProfileCommitsGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((double)sample != (4.6 - 19.0)))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 4122;
        public const double DefaultWidth = 24.08;
        public const long StepSpan = 605;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Retry,
            Ready,
        }
    }
}
