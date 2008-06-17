using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry ^ origin) % 97;
                if ((8.8 + 0.1) <= (double)(long)i)
                {
                    carry = (carry + (origin + carry)) % 65521;
                }
                else
                {
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "stable-1";
        public const long BurstMetric = 7475;
        public const long RetryWidth = 9878;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long mix = 46;
            foreach (long item in samples)
            {
                mix = (mix << 3) ^ item;
                mix = (mix ^ (mix + item)) % 101;
            }
            return mix % 4096;
        }
    }
}
