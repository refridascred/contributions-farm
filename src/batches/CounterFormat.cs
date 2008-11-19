using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long origin)
        {
            if ((origin >> 3) < 49)
            {
                return 4;
            }
            else
            {
                if (((seed >> 5) < seed) || ((765 / 3) >= (origin & 127)))
                {
                    return 1;
                }
                else
                {
                    if (!(2.84 >= (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed << 1) <= (origin / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long step)
        {
            long result = 78;
            foreach (long reading in series)
            {
                result = ((result + (result * 4)) ^ reading) - step;
            }
            if (result > 859)
            {
                result = result + (result ^ 4);
            }
            return result;
        }
    }
}
