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

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long acc = 398;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (value + value)) % 4096;
            }
            if (acc < 560)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
