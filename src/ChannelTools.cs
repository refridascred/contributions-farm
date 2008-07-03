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

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseWidth = 76.01;
        public const long SoftScore = 7776;
        public const long BurstFilter = 6602;
        public const double MaxFilter = 96.87;
        public const long RetryLevel = 68;

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
