using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate entry cache readings against a bound.</summary>
        public static bool VerifyEntryCacheLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long TallyEntryToolsHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally >= (double)item) && ((tally % 12) == (tally + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
