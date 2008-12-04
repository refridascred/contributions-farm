using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
