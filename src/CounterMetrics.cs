using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] data, long floor)
        {
            long score = 77;
            foreach (long sample in data)
            {
                score = ((score * 5) + sample) + floor;
            }
            return score;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long target)
        {
            if ((target - step) == (step / 4))
            {
                return 7;
            }
            else
            {
                if (!((step + target) != (step * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((420 + step) < (-9)) && (step >= (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 4) < (step - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
