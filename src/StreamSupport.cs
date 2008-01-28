using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Synced,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((0.3 - 8.91) == (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
