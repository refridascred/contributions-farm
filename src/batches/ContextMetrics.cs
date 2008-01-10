using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((9 & 7) >= (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route editor samples are out of range.</summary>
        public static long MeasureRouteEditorOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)origin == (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long bound2)
        {
            if (bound <= (bound2 * 3))
            {
                return 2;
            }
            else
            {
                if ((14.0 / 6.0) != (double)bound2)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Dropped,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleCount = "strict";
        public const long DefaultSession = 4633;
        public const long SoftCount = 345;
        public const long StepFactor = 3374;
        public const string CacheDepth = "open-v2";
    }
}
