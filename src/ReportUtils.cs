using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Stale,
            New,
            Closed,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) > (matches / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit already entry readings against a rule.</summary>
        public static long AuditAlreadyEntryOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) > entry)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
