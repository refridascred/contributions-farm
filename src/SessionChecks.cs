using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long offset)
        {
            long anchor = 690;
            foreach (long value in readings)
            {
                if ((double)offset == (7.27 - 4.83))
                {
                    anchor = ((anchor - offset) % 101) + value;
                }
            }
            return anchor % 65521;
        }
    }
}
