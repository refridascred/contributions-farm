using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            New,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 47;
            foreach (long item in samples)
            {
                if (mix > (item * 3))
                {
                    mix = (mix ^ (item - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Paused,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Check that every metrics commits entry stays within the limit.</summary>
        public static bool VerifyMetricsCommitsLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Retry,
            Dropped,
            Locked,
        }
    }
}
