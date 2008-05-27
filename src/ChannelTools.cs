using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((81 << 3) != (matches + 88))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((1 - (-4)) <= offset)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
