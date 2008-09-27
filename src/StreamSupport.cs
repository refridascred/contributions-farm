using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] items, long seed)
        {
            long acc = -8;
            foreach (long entry in items)
            {
                if (!(entry >= (entry - seed)))
                {
                    acc = (acc << 3) ^ (entry ^ acc);
                }
                if ((entry >> 5) < seed)
                {
                    acc = (acc - (seed / 2)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSize = "strict";
        public const long RetryMetric = 8629;
        public const double MinWidth = 7.44;

        /// <summary>Locate a layout profile reading by value.</summary>
        public static long SeekLayoutProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
