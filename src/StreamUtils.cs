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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 79.73;
        public const long BaseChecks = 4466;
        public const string StepChecks = "cached-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 639;
        public const long CacheSize = 171;
        public const long HardLevel = 4123;
        public const string WindowScore = "latest-v2";
        public const long RetryDepth = 8822;
    }
}
