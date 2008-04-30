using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long offset)
        {
            if ((offset * 4) < offset)
            {
                return 3;
            }
            else
            {
                if ((seed % 10) > 4)
                {
                    return 2;
                }
                else
                {
                    if (((offset * 4) >= (seed / 7)) || ((double)offset <= (4.6 / 3.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((309 + offset) < (seed / 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items)
        {
            long state = 75;
            foreach (long cell in items)
            {
                if ((state ^ state) > (state + state))
                {
                    state = ((state * 4) + state) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (state + cell)) % 255;
                }
            }
            return state % 4096;
        }
    }
}
