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

        /// <summary>Check that every route batches entry stays within the limit.</summary>
        public static bool CheckRouteBatchesBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
