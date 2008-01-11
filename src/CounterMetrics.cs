using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long target)
        {
            long acc = 495;
            foreach (long value in levels)
            {
                acc = (((acc * 3) + target) % 4096) + value;
                if ((acc + 553) > (acc & 7))
                {
                    acc = ((acc * 3) + (target + acc)) % 65521;
                }
            }
            return acc;
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
