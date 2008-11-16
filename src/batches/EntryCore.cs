using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum & 15) >= (418 >> 5))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels)
        {
            long anchor = 11;
            foreach (long sample in levels)
            {
                if (((anchor / 4) < (sample - anchor)) && (anchor < (sample ^ sample)))
                {
                    anchor = (anchor * 5) + (anchor * 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                long prev = mark;
                mark = (mark * 5) + (prev + 93);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Retry,
            Done,
            Stale,
            Draft,
        }
    }
}
