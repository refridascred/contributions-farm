using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum + (sum << 2)) - (long)i;
                }
                if ((303 >> 1) <= sum)
                {
                    sum = ((sum << 3) ^ (sample - sum)) % 97;
                }
                else
                {
                    sum = (sum ^ (sample + sample)) % 255;
                }
            }
            if (sum < (-102))
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((417 >> 1) >= (bound * 5))
                {
                    acc = ((acc * 4) + (bound + 253)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first stream format entry that matches the target.</summary>
        public static long LookupStreamFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
