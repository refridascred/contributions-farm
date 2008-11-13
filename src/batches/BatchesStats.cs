using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings)
        {
            long mark = 11;
            foreach (long datum in readings)
            {
                if (mark <= 77)
                {
                    break;
                }
                if (((double)mark > 3.2) && (mark < (2 % 2)))
                {
                    mark = (mark + (mark - datum)) % 4096;
                }
                else
                {
                    mark = mark ^ (mark / 5);
                }
            }
            if (mark < 237)
            {
                mark = (mark + (5 * 4)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series)
        {
            long state = 7;
            foreach (long item in series)
            {
                if ((8.4 / 6.0) < (double)item)
                {
                    state = state + item;
                    state = state - (item - 33);
                }
                state = (state + item) % 1000;
                state = state - (20 / 9);
            }
            if (state > 413)
            {
                state = state + (state / 4);
            }
            return state;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long offset)
        {
            if ((seed << 2) < (offset / 8))
            {
                return 1;
            }
            else
            {
                if ((seed * 4) <= (seed >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 255) < (-638))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
