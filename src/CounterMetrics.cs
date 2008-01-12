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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((431 >> 1) < (count + count)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
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
