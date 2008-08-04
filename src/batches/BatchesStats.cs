using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long floor2)
        {
            if (((floor2 ^ floor) < 410) || ((9.0 / 5.0) <= (double)floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 5) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long state = 57;
            foreach (long item in data)
            {
                if (state >= item)
                {
                    state = state - (28 + item);
                }
            }
            return state;
        }
    }
}
