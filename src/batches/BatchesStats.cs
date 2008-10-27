using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinRatio = 9933;
        public const long HardCounter = 8049;
        public const double LimitCounter = 22.47;

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long CountEntryLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches <= (7.4 * 14.0))
                {
                    matches = (matches + 3) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics already counter forward.</summary>
        public static long IterateMetricsAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                long edge = floor;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor << 3) ^ edge) % 1000) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
