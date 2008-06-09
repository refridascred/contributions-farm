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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
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
