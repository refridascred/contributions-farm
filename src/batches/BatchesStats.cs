using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 626;
            foreach (long value in values)
            {
                mark = (mark * 3) + value;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback-v2";
        public const double MinSpan = 75.1;
        public const double MinChecks = 90.03;

        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long CountProfileSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((707 % 2) < (matches & 63))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor - (step + step)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
