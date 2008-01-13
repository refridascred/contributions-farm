using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long AuditFarmContextMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((origin ^ tally) > 0)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((item - item) < item) && ((item % 8) > (item + item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
