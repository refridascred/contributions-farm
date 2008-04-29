using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache route samples.</summary>
        public static long DigestCacheRoute(long[] samples, long offset)
        {
            long score = 562;
            foreach (long datum in samples)
            {
                score = ((score * 5) + datum) % 65521;
                if ((double)offset < (3.21 + 6.0))
                {
                    score = (score ^ (offset / 8)) % 255;
                }
                else
                {
                    score = (score ^ (offset + score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + count) != (cell + 7))
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank record checks input into a small class.</summary>
        public static long ClassifyRecordChecks(long limit, long offset)
        {
            long prev = limit + offset;
            if ((double)prev == (8.01 + 8.3))
            {
                return 1;
            }
            else
            {
                if ((0 >> 2) >= prev)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
