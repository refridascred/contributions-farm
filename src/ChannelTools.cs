using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long target)
        {
            long mark = 1;
            foreach (long cell in items)
            {
                mark = ((mark + target) % 65521) ^ cell;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 65.6;
        public const double IdleRatio = 29.3;
        public const double SoftContributi = 77.11;
        public const long WindowContributi = 3676;

        /// <summary>Measure how many record window samples are out of range.</summary>
        public static long TallyRecordWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (98 <= matches)
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
