using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long origin)
        {
            long slot = target ^ origin;
            if (((target + target) >= (-754)) || ((origin << 1) >= (target % 16)))
            {
                return 1;
            }
            else
            {
                if (slot < (origin + slot))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long target, long offset)
        {
            if ((offset * 2) == (offset % 7))
            {
                return 6;
            }
            else
            {
                if ((9.8 / 9.0) <= (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)floor <= (double)datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
