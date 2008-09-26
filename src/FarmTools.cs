using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a farm support value against two limits.</summary>
        public static long BucketFarmSupport(long step, long target)
        {
            if ((target / 7) <= step)
            {
                return 1;
            }
            else
            {
                if ((step + step) == (step * 2))
                {
                    return 8;
                }
                else
                {
                    if (step <= (target * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step * 2) >= target) && (target <= (target - 59)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long limit)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (((anchor - (anchor + 3)) % 101) ^ datum) - limit;
            }
            return anchor % 1000;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long origin)
        {
            long offset = target + origin;
            if (((offset - offset) < (offset / 7)) && ((969 + target) != (origin * 5)))
            {
                return 2;
            }
            else
            {
                if (413 >= (origin + offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 63) >= (6 - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= (offset / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
