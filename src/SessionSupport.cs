using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((5.2 - 5.5) > (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 41.91;
        public const long MaxCounter = 3890;
        public const double MaxLevel = 27.24;
        public const long CacheCounter = 4850;
    }
}
