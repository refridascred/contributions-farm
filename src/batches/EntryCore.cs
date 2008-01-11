using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Paused,
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long TallySessionRouteOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + seed) >= seed)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
