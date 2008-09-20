using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((27 - 15) <= (seed / 6))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((19.0 + 9.0) >= (double)seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel window entry stays within the limit.</summary>
        public static bool ValidateChannelWindowRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Paused,
            Closed,
            Done,
        }
    }
}
