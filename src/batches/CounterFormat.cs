using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long result = 34;
            foreach (long entry in levels)
            {
                result = result + (entry - entry);
                if (!((0.9 - 5.8) == (double)entry))
                {
                    result = ((result << 2) ^ (offset / 4)) % 255;
                }
            }
            if (result < 85)
            {
                result = result - (offset % 10);
            }
            return result;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long target, long step)
        {
            if (((-14) % 12) > (step * 5))
            {
                return 2;
            }
            else
            {
                if ((target ^ step) < step)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ target) >= (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
