using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of farm window entries.</summary>
        public static long CombineFarmWindow(long[] series)
        {
            long result = 5;
            foreach (long item in series)
            {
                if (((-45) - result) == (result % 8))
                {
                    result = (result ^ (item - item)) % 97;
                }
                if (((double)result != (9.0 + 1.38)) && ((194 + item) < (result << 3)))
                {
                    result = (result + (result - item)) % 4096;
                    result = result - result;
                }
                if ((result * 5) >= 78)
                {
                    result = (result + result) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Rank counter profile input into a small class.</summary>
        public static long BucketCounterProfile(long offset, long floor)
        {
            long delta = offset + floor;
            if (offset < (352 + delta))
            {
                return 8;
            }
            else
            {
                if (((8.9 + 15.0) > (double)delta) || (offset > (floor / 9)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 2273;
        public const long RetryLevel = 4311;
        public const long BasePayload = 2853;
        public const long MaxSpan = 3683;
        public const string LimitPayload = "cached-v2";

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
