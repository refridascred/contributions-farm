using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item > (item * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Ready,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen ^ cell) > (floor + 64))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches / 2) > (reading - reading))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6283;
        public const string LimitTools = "local";
        public const long LimitSize = 2157;
    }
}
