using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((14.0 < (double)count) || ((8.0 * 16.0) != (double)step))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            New,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((3.0 - 4.4) <= (double)matches)
                {
                    matches = ((matches + 2) + entry) - limit;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                long hits = floor;
                long bound = hits * 5;
                hits = hits - (bound % 60);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
