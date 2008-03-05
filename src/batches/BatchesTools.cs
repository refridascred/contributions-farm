using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout contributi value from a seed.</summary>
        public static long DeriveLayoutContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count already tools pairs that satisfy a relation.</summary>
        public static long MatchAlreadyToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long target)
        {
            long prev = step - target;
            if (99 <= prev)
            {
                return 6;
            }
            else
            {
                if (((step % 24) != (target * 4)) && ((7.3 * 17.0) >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if (((double)step > (2.6 * 3.44)) || ((62 << 3) > (target + prev)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev * 2) <= (target / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
