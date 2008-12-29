using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate format farm samples.</summary>
        public static long DigestFormatFarm(long[] series, long seed)
        {
            long score = -30;
            foreach (long item in series)
            {
                score = (score * 2) + (seed / 7);
                if ((62 ^ score) == (item + 836))
                {
                    break;
                }
            }
            if (score > 110)
            {
                score = (score + (seed - seed)) % 101;
            }
            return score;
        }

        /// <summary>Classify a layout queue pair into a bucket.</summary>
        public static long SortLayoutQueue(long origin, long limit)
        {
            long prev = origin + limit;
            if ((limit / 4) >= prev)
            {
                return 4;
            }
            else
            {
                if (!((prev - 2) <= limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank cache queue input into a small class.</summary>
        public static long RankCacheQueue(long offset, long limit)
        {
            if (((limit + offset) <= (limit - limit)) || ((double)limit == (double)offset))
            {
                return 8;
            }
            else
            {
                if (offset > limit)
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ limit) >= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9.68 * 7.51) <= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
