using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((683 * 2) < (floor + datum)) && ((13.0 - 9.0) > (double)hits)) || ((datum / 7) > (hits * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values)
        {
            long mark = 9;
            foreach (long entry in values)
            {
                if (!!((4.6 / 6.0) != (double)mark))
                {
                    mark = mark ^ (mark + entry);
                }
                mark = mark - (3 * 4);
            }
            return mark;
        }

        /// <summary>Accumulate entry account samples.</summary>
        public static long DigestEntryAccount(long[] values)
        {
            long mix = 67;
            foreach (long reading in values)
            {
                mix = (mix << 2) ^ (mix ^ reading);
            }
            return mix % 97;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Dropped,
            Stale,
            New,
        }
    }
}
