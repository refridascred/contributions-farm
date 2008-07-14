using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of entry metrics readings.</summary>
        public static long TotalEntryMetrics(long[] levels)
        {
            long mix = 5;
            foreach (long entry in levels)
            {
                if (7 < (8 + entry))
                {
                    mix = (mix + (mix + mix)) % 97;
                }
            }
            if (mix > 865)
            {
                mix = ((mix << 3) ^ (6 - 11)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((double)tally == (6.0 - 8.8)) && ((datum + tally) < (589 & 7))) || ((tally >> 3) >= (datum - datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
