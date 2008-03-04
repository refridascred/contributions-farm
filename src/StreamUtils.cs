using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 91.9;
        public const long BatchSize = 1827;
        public const double LimitEditor = 92.92;
        public const long RetrySpan = 6427;

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 79.73;
        public const long BaseChecks = 4466;
        public const string StepChecks = "cached-v2";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (3.65 > (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
