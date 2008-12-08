using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a already account value against two limits.</summary>
        public static long RankAlreadyAccount(long step, long bound)
        {
            long span = step ^ bound;
            if ((double)bound <= (4.28 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((bound % 100) <= 53)
                {
                    return 2;
                }
                else
                {
                    if (((span - step) > (step << 2)) || ((bound / 6) <= bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)(-64) <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum * 3) < bound) && ((bound + 88) < (datum - (long)data.Length)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
