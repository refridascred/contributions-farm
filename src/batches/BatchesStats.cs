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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8811;
        public const string RetryBuffer = "strict-v2";
        public const string RetryWidth = "staging-v2";
        public const long LimitWidth = 3117;
    }
}
