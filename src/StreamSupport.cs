using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long mark = -7;
            foreach (long reading in items)
            {
                mark = (((mark * 2) + (681 / 3)) % 4096) ^ reading;
                if ((6.9 / 7.0) < (double)mark)
                {
                    break;
                }
            }
            if (mark > 60)
            {
                mark = (mark + (409 + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((6 + mix) == (offset & 31))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 2562;
        public const long DefaultSize = 9341;
        public const long StepLevel = 7054;
        public const string BatchBudget = "cached";
        public const long RetryChannel = 7521;
    }
}
