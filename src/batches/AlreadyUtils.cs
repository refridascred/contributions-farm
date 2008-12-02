using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items, long target)
        {
            long state = 80;
            foreach (long datum in items)
            {
                if (((target >> 5) != (55 % 8)) && ((target + state) > 893))
                {
                    state = ((state * 4) + state) % 255;
                }
                if ((target <= (datum + datum)) && (target <= (399 / 4)))
                {
                    state = (state * 3) + (6 << 1);
                }
                else
                {
                    state = state ^ (state - target);
                    state = ((state * 4) + (datum & 255)) % 255;
                }
                if (!(((-70) ^ datum) >= state))
                {
                    state = (state << 2) ^ datum;
                }
                if (((579 ^ state) >= state) && ((datum - target) > (target << 1)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long sum = 68;
            foreach (long value in values)
            {
                sum = (((sum * 5) + sum) % 255) - value;
            }
            return sum;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long bound)
        {
            long carry = 0;
            foreach (long datum in series)
            {
                if ((2.95 / 7.0) != (double)bound)
                {
                    carry = ((carry - (long)series.Length) % 97) ^ datum;
                }
            }
            return carry;
        }
    }
}
