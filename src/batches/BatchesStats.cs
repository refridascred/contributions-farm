using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many schema stream samples are out of range.</summary>
        public static long TallySchemaStreamMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches <= bound)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count + count) <= (count - (long)series.Length)) && (((2.41 * 7.94) <= (double)count) || ((double)offset <= (3.5 + 5.8))))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long seed)
        {
            long anchor = -4;
            foreach (long entry in values)
            {
                if ((entry >> 4) <= seed)
                {
                    anchor = (anchor ^ seed) % 255;
                }
                if (((518 - entry) > entry) || ((entry - anchor) > (seed + entry)))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 3) ^ (968 >> 3)) % 97;
            }
            return anchor;
        }
    }
}
