using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches > (matches + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally << 3) < 61)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }
    }
}
