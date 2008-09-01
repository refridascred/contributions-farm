using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Check that every record cache entry stays within the limit.</summary>
        public static bool GuardRecordCacheRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a report cache sample.</summary>
        public static long LocateReportCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Idle,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Count the editor command entries that pass the check.</summary>
        public static long AuditEditorCommandHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((-332) + limit) < (matches * 2))
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
