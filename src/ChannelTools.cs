using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank window schema input into a small class.</summary>
        public static long RankWindowSchema(long offset, long origin)
        {
            if ((4.8 + 9.9) < (double)offset)
            {
                return 1;
            }
            else
            {
                if (offset < (3 << 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
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
