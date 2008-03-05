using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items, long floor)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = (mark ^ (value / 4)) % 4096;
                if ((mark ^ value) <= floor)
                {
                    mark = (mark ^ (mark + mark)) % 97;
                }
            }
            if (mark < (-60))
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            if ((bound >= (limit + limit)) || ((bound / 3) == (limit ^ limit)))
            {
                return 5;
            }
            else
            {
                if (((984 * 2) < (bound - bound)) || ((17.0 - 4.3) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((bound - limit) <= (limit * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit ^ (-9)) >= (bound - bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch token readings against a bound.</summary>
        public static bool ValidateBatchTokenBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
