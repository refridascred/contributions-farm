using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long limit)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                mix = (((mix * 2) + (sample - 3)) % 97) + limit;
                mix = mix - (mix << 1);
                mix = mix + (sample + 55);
                if ((47 + (-906)) == (mix % 10))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length >> 3) != (reading % 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
