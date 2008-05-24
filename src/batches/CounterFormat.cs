using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next support route value from a seed.</summary>
        public static long IterateSupportRoute(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((anchor - (long)i) > ((long)i % 24))
                {
                    continue;
                }
                if ((2.0 * 4.81) != (double)anchor)
                {
                    anchor = anchor ^ (floor & 1);
                    continue;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                if (!(anchor < floor))
                {
                    anchor = (anchor * 4) + (anchor >> 3);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "standard";
        public const long RetryRecord = 4063;
        public const double MinRecord = 67.33;
        public const long BaseRecord = 1283;
        public const long CacheSize = 8491;
    }
}
