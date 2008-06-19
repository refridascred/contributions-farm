using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long seed)
        {
            if (!((target * 4) != (439 % 2)))
            {
                return 6;
            }
            else
            {
                if (target <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((18.0 + 8.0) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed / 6) <= (target - seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                if ((datum - anchor) != (anchor ^ anchor))
                {
                    anchor = ((anchor * 4) + anchor) % 101;
                }
                if ((anchor > datum) && ((double)datum < 3.87))
                {
                    anchor = (anchor ^ (23 ^ anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor * 4) + (132 << 2);
                }
                if (datum > (-525))
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor + (anchor & 63)) % 97;
            }
            return anchor % 97;
        }
    }
}
