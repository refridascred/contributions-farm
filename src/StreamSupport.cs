using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long mark = 537;
            foreach (long reading in samples)
            {
                mark = (((mark * 5) + (61 & 127)) % 1000) ^ reading;
            }
            return mark;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 8;
            foreach (long sample in items)
            {
                state = (state + 198) ^ sample;
            }
            return state % 97;
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
