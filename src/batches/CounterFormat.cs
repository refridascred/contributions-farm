using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long total = 1;
            foreach (long datum in levels)
            {
                total = (total - (total >> 3)) + datum;
            }
            return total;
        }

        /// <summary>Rank report layout input into a small class.</summary>
        public static long RankReportLayout(long origin, long target)
        {
            long bound = origin + target;
            if (origin >= (target >> 2))
            {
                return 4;
            }
            else
            {
                if (!((origin * 3) >= bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)target < (6.01 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin - target) > (bound + bound))
                        {
                            return 8;
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
