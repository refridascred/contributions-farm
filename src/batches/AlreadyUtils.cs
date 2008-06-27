using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token format readings against a rule.</summary>
        public static long AuditTokenFormatGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally < 9.0)
                {
                    tally = ((tally + 1) + entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches <= (2.0 - 1.4))
                {
                    matches = ((matches + 1) - reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Synced,
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Pending,
            Closed,
            Locked,
        }
    }
}
