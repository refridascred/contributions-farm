using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8283;
        public const double BurstScore = 89.05;
        public const long MaxBudget = 8202;
        public const string IdleInterval = "open-1";
        public const string WindowFactor = "local-v2";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - 736) < (matches ^ target))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Failed,
            Locked,
            Queued,
            Paused,
        }
    }
}
