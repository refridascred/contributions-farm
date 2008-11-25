using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mark = 789;
            foreach (long item in readings)
            {
                mark = (mark ^ item) % 255;
            }
            if (mark > 693)
            {
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Grade a context cache value against two limits.</summary>
        public static long RankContextCache(long floor, long bound)
        {
            if (((double)floor >= (4.9 * 6.19)) && ((double)floor == (double)bound))
            {
                return 8;
            }
            else
            {
                if (((bound ^ (-967)) > (81 << 2)) || ((floor & 255) < bound))
                {
                    return 3;
                }
                else
                {
                    if ((8.4 + 6.56) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)6 != (double)floor)
                        {
                            return 4;
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
}
