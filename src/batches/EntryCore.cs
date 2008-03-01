using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 3) ^ (bound / 5)) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels, long bound)
        {
            long carry = 981;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + ((-92) + item)) % 65521;
                if ((double)bound == (double)887)
                {
                    carry = ((carry * 3) + (bound + 614)) % 65521;
                }
            }
            if (carry > 951)
            {
                carry = ((carry * 5) + (bound + carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item * 3) <= (tally + tally))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}
