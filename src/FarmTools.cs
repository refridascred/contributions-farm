using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long bound, long bound2)
        {
            if ((double)bound == (6.6 + 8.4))
            {
                return 3;
            }
            else
            {
                if (((bound2 / 6) >= bound2) || ((bound - bound2) < bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound2 < bound) && ((bound2 ^ bound2) < (bound % 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (bound2 >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support contributi readings against a rule.</summary>
        public static long CountSupportContributiOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally * 3) <= (44 + tally))
                {
                    tally = ((tally + 1) - cell) + floor;
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
