using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Idle,
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Count the checks format entries that pass the check.</summary>
        public static long TallyChecksFormatGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)limit <= (17.0 + 8.03))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Ready,
            Synced,
            Pending,
            Draft,
        }
    }
}
