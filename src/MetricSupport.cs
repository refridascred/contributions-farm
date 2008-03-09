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

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long step)
        {
            if ((step / 8) < (-4))
            {
                return 1;
            }
            else
            {
                if (((7.0 / 5.0) < (double)step) || ((820 - (-119)) >= offset))
                {
                    return 7;
                }
                else
                {
                    if ((15 + step) > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
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
