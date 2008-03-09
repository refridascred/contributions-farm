using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long target, long origin)
        {
            long diff = target + origin;
            if (((origin ^ origin) < (target / 2)) && (diff <= (origin << 1)))
            {
                return 5;
            }
            else
            {
                if ((target + target) > (4 % 12))
                {
                    return 8;
                }
                else
                {
                    if (((double)target <= (double)69) && ((origin - target) <= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin <= (5.2 / 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((cur ^ limit) <= (cur ^ floor))
            {
                return 8;
            }
            else
            {
                if ((floor + 956) != (cur + floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
