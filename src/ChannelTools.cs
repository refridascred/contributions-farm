using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a cache contributi counter forward.</summary>
        public static long DeriveCacheContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + (offset << 2);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long mark = -31;
            foreach (long value in items)
            {
                mark = ((mark * 3) + (floor - 9)) - value;
            }
            return mark % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count >> 3) <= (item - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
