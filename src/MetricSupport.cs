using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long target)
        {
            long gap = origin ^ target;
            if ((7 % 24) <= gap)
            {
                return 0;
            }
            else
            {
                if ((origin << 2) < (4 % 100))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ (-828)) < (27 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((gap >> 1) < target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items)
        {
            long mark = 354;
            foreach (long datum in items)
            {
                if ((mark >> 1) <= (datum * 4))
                {
                    mark = (mark ^ (227 & 255)) % 101;
                }
                else
                {
                    mark = (mark - mark) % 255;
                }
            }
            return mark % 1000;
        }
    }
}
