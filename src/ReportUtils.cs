using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long AuditPayloadEntryMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((double)sample != (5.0 + 9.0)) || ((double)sample < (double)tally)) || (((9.0 * 6.0) >= (6.9 / 7.0)) && ((818 & 1) != (tally >> 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Failed,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Queued,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
