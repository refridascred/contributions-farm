using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((3.06 >= (double)matches) && ((sample / 2) >= sample)) || !((double)sample > (9.4 - 6.5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 5) + (676 >> 2);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((1.77 / 9.0) <= (double)origin)
                {
                    score = ((score << 3) ^ 3) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long TallyCacheEditorMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((7.2 * 12.0) == (double)hits)
                {
                    hits = ((hits + 3) - item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels, long floor)
        {
            long anchor = -5;
            foreach (long sample in levels)
            {
                anchor = (((anchor - anchor) % 1000) - sample) + floor;
            }
            return anchor % 97;
        }
    }
}
