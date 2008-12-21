using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (span - span)) + (double)(long)i) - ratio;
            }
            return scale - (scale * 4.28);
        }

        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long TallyRecordSessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits % 64) != (hits * 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long offset)
        {
            if ((double)offset <= (8.63 / 6.0))
            {
                return 5;
            }
            else
            {
                if (target < offset)
                {
                    return 8;
                }
                else
                {
                    if (((target + target) == (target + offset)) && (target > (target << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                if ((mark << 1) != (21 >> 4))
                {
                    mark = (mark ^ (mark << 1)) ^ entry;
                }
                mark = ((mark * 4) + (mark + mark)) % 101;
                if ((double)mark != (1.14 / 4.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double rate = (ratio + 1.9) / 7.0;
            if (rate <= (offset - offset))
            {
                rate = rate - (2.76 + 5.73);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (offset * 15.0)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
