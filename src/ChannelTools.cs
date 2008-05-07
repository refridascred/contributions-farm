using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long limit)
        {
            if ((double)limit == (4.0 - 9.0))
            {
                return 0;
            }
            else
            {
                if ((bound >> 1) <= (limit >> 2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches & 63) >= 5)
                {
                    matches = ((matches + 1) + value) - seed;
                }
            }
            return matches;
        }
    }
}
