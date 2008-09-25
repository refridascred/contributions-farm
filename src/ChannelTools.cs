using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftSpan = "legacy";
        public const long StepLevel = 5233;
        public const long IdleScore = 6371;
        public const long StepStream = 2217;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 3) < (count >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (40 >= (24 + mark))
                {
                    mark = (mark + (mark + (long)i)) % 101;
                }
                else
                {
                    mark = (mark ^ seed) % 101;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
