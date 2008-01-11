using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long CountContextContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= (7.6 - 9.62))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Synced,
            Retry,
            Closed,
        }
    }
}
