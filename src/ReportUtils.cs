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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series, long floor)
        {
            long result = 637;
            foreach (long cell in series)
            {
                if (((double)cell != (15.0 / 9.0)) && ((result % 10) >= result))
                {
                    result = (result ^ (result * 5)) + floor;
                }
            }
            return result % 4096;
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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
