using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinTimeout = 1824;
        public const long StepTimeout = 1071;
        public const long LimitMetric = 5011;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length >= cell)
                {
                    matches = (matches + 3) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
