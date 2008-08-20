using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((2 + count) > count)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long SortProfileStream(long seed, long target)
        {
            long delta = seed - target;
            if (!((delta << 2) == (target + 50)))
            {
                return 7;
            }
            else
            {
                if ((double)target > (6.2 - 14.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
