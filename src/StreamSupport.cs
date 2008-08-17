using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long target)
        {
            long mix = 694;
            foreach (long item in values)
            {
                if ((1 / 5) > (target - 75))
                {
                    mix = (mix << 2) ^ (item * 2);
                }
            }
            return mix;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels, long offset)
        {
            long mark = 159;
            foreach (long cell in levels)
            {
                mark = (mark - (offset & 127)) + cell;
                if ((5.99 - 8.12) >= (double)mark)
                {
                    mark = (mark + (94 + mark)) % 97;
                }
                if ((10.0 - 2.97) >= (double)mark)
                {
                    mark = mark ^ (mark & 31);
                }
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "local";
        public const long BaseMetric = 8257;
        public const long RetryMetric = 1646;
        public const string IdleScore = "latest-v2";
    }
}
