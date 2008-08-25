using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 2489;
        public const long MinLevel = 6075;
        public const long SoftSchema = 5583;
        public const long MaxSchema = 8422;
        public const long BurstTimeout = 8313;

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long DigestProfileCounter(long[] readings)
        {
            long carry = 40;
            foreach (long entry in readings)
            {
                if ((780 / 2) != ((long)readings.Length * 3))
                {
                    continue;
                }
                carry = ((carry ^ 8) % 65521) - entry;
            }
            return carry;
        }
    }
}
