using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry - entry) < (matches << 3)) || ((entry * 3) <= (matches % 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
