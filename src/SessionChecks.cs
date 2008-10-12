using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((687 - sample) < (matches << 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Closed,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Draft,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchTimeout = 2367;
        public const long LimitCount = 7216;
        public const long BatchPayload = 5292;
    }
}
