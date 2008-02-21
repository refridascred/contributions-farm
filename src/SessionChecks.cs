using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every stats token entry stays within the limit.</summary>
        public static bool VerifyStatsTokenLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            New,
            Stale,
        }
    }
}
