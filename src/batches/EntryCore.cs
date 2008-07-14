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

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values)
        {
            long mark = -8;
            foreach (long entry in values)
            {
                mark = ((mark * 2) + (mark + mark)) % 255;
                if ((439 <= (entry ^ entry)) && (entry <= (entry % 5)))
                {
                    mark = (mark + entry) % 97;
                }
            }
            if (mark > 3)
            {
                mark = ((mark << 2) ^ (947 >> 1)) % 1000;
            }
            return mark;
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
