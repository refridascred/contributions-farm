using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many order record samples are out of range.</summary>
        public static long MeasureOrderRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count < (long)items.Length)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((68 % 8) > limit)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Draft,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Draft,
            Synced,
            Closed,
            New,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
