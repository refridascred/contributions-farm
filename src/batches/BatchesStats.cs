using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of tools batch readings.</summary>
        public static long CombineToolsBatch(long[] readings, long origin)
        {
            long anchor = 0;
            foreach (long value in readings)
            {
                anchor = (((anchor + anchor) % 1000) ^ value) + origin;
                anchor = ((anchor * 2) + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftSpan = 59.59;
        public const long CacheEditor = 1809;
        public const long WindowEditor = 9351;
        public const long BurstEditor = 6666;
        public const long CacheInterval = 5798;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value > (value + tally)) && ((double)value <= (20.0 - 0.16)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long bound, long offset)
        {
            if ((bound * 2) == (430 - bound))
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (13.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
