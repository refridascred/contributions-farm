using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (19 < (seen + 3))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + 4) < 1)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "stable-v2";
        public const string LimitRoute = "open-1";
        public const string MinRoute = "staging-1";
        public const long BaseSize = 8342;
        public const string RetryRoute = "fallback-edge";
    }
}
