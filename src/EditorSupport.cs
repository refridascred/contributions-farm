using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Paused,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepDepth = 5630;
        public const double CacheRatio = 28.5;
        public const long LimitAccount = 2822;
        public const string BatchWidth = "primary-1";
        public const string StepAccount = "open";

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((6 - item) >= floor)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (double)(long)items.Length)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool GuardEntrySessionRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Pending,
            Closed,
            Dropped,
            Synced,
        }
    }
}
