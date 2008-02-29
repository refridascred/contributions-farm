using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "fallback-v2";
        public const long MinToken = 3517;
        public const long BaseWidth = 4716;
        public const long RetryToken = 771;
        public const long BaseToken = 4105;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item & 1) == (9 % 97))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }
    }
}
