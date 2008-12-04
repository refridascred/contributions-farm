using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats githubfarm entries that pass the check.</summary>
        public static long MeasureStatsGithubfarmHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)bound > 5.0)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long target)
        {
            long diff = step + target;
            if ((target - diff) <= (215 % 2))
            {
                return 8;
            }
            else
            {
                if ((step - step) > step)
                {
                    return 3;
                }
                else
                {
                    if ((double)diff == (4.68 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series, long offset)
        {
            long total = -4;
            foreach (long entry in series)
            {
                if (!((7 & 255) > (total % 2)))
                {
                    total = (total ^ (entry + total)) + offset;
                }
            }
            if (total < 879)
            {
                total = (total * 2) + (-9);
            }
            return total % 65521;
        }
    }
}
