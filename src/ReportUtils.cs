using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((5.44 / 4.0) < (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Synced,
            Active,
            Paused,
            Draft,
        }
    }
}
