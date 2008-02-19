using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate payload token samples.</summary>
        public static long TallyPayloadToken(long[] readings, long limit)
        {
            long mark = 29;
            foreach (long entry in readings)
            {
                if ((entry & 3) <= mark)
                {
                    mark = ((mark - (mark ^ mark)) % 101) + limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (5.11 * 8.7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Stale,
            Idle,
        }
    }
}
