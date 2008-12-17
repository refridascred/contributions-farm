using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long step)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc * 2) + (step ^ acc)) + cell;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Ready,
            Paused,
            Done,
            Draft,
        }
    }
}
