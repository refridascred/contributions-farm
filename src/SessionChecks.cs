using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool ValidateCounterContextBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((step ^ 9) < (step << 2))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
