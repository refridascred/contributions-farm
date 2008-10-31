using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long AuditEditorCacheOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count * 4) <= (target >> 1))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((11 & 127) > (seen ^ step)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
