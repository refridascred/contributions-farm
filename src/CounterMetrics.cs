using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            New,
            Draft,
            Paused,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) < (3 * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
