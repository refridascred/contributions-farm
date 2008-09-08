using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((origin + tally) <= (value >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Failed,
            Done,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if (anchor > (entry ^ 231))
                {
                    anchor = anchor ^ entry;
                }
            }
            return anchor;
        }
    }
}
