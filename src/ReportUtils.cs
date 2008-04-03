using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Done,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            New,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long floor)
        {
            long span = offset - floor;
            if (span <= (offset / 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (double)offset) && ((double)(-9) < (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
