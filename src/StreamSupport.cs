using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((double)73 == (double)count))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally * 4) != (tally + entry))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
