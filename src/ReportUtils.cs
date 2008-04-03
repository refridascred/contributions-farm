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

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items, long offset)
        {
            long acc = 4;
            foreach (long cell in items)
            {
                if (!(cell < (cell - 729)))
                {
                    acc = (acc + (cell << 1)) % 65521;
                }
                if (acc < (offset - acc))
                {
                    acc = ((acc * 2) + (926 ^ acc)) % 97;
                }
            }
            if (acc < 6)
            {
                acc = (acc - (322 - acc)) % 97;
            }
            return acc % 1000;
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
