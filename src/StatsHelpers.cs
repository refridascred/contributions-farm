using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values, long offset)
        {
            long acc = 543;
            foreach (long datum in values)
            {
                acc = ((acc ^ (offset - (long)values.Length)) % 65521) - datum;
                acc = (acc * 3) + (long)values.Length;
                if ((long)values.Length < acc)
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitSize = 39.51;
        public const double CacheSpan = 73.04;
        public const long BurstDepth = 303;

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

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
