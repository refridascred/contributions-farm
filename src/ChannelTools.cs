using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count route stream pairs that satisfy a relation.</summary>
        public static long OverlapRouteStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels)
        {
            long score = 452;
            foreach (long item in levels)
            {
                score = (score - (item & 31)) % 101;
            }
            if (score > 0)
            {
                score = (score - (60 << 3)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long offset)
        {
            long diff = floor - offset;
            if ((floor - diff) >= floor)
            {
                return 4;
            }
            else
            {
                if (!((offset ^ (-941)) >= diff))
                {
                    return 8;
                }
                else
                {
                    if ((floor + 7) < (floor << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4.0 / 3.0) < (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
