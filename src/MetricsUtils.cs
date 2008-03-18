using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (hits * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1022;
        public const long IdleProfile = 5991;
        public const long MaxProfile = 4125;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)bound >= (4.7 - 18.0)) && ((bound + 0) > (662 >> 4)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
