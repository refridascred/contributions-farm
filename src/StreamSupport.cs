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

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 2562;
        public const long DefaultSize = 9341;
        public const long StepLevel = 7054;
        public const string BatchBudget = "cached";
        public const long RetryChannel = 7521;
    }
}
