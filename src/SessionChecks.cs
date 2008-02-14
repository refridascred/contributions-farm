using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally < (target % 24)) && (entry < (target << 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Synced,
            Closed,
        }
    }
}
