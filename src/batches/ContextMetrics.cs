using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit counter report readings against a rule.</summary>
        public static long TallyCounterReportMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) < (tally / 2))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Ready,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally ^ item) >= (item >> 4)) || (item < (item + (-66))))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Synced,
            Dropped,
            Stale,
            Locked,
        }
    }
}
