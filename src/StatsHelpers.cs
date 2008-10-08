using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((seed + seed) > (847 % 7))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((floor >= (datum >> 1)) || ((floor / 8) <= (tally / 3))) && (floor <= (tally - tally)))
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

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Paused,
            Done,
            Closed,
        }
    }
}
