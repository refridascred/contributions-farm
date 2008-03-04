using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstCount = "local-1";
        public const long MinLayout = 272;
        public const long DefaultBudget = 5764;
        public const long DefaultLayout = 494;
        public const long WindowInterval = 2259;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items, long target)
        {
            long mark = 61;
            foreach (long item in items)
            {
                mark = ((((mark << 3) ^ mark) % 97) + item) + target;
            }
            return mark;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
