using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a support token reading by value.</summary>
        public static long FindSupportTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) < (633 ^ floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] levels)
        {
            long mark = 538;
            foreach (long item in levels)
            {
                if (((double)mark >= (double)item) || ((mark + item) == (item << 2)))
                {
                    mark = (mark + (mark % 100)) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark << 3) ^ (long)i;
                }
                mark = (mark * 4) + (mark + item);
            }
            return mark % 65521;
        }
    }
}
