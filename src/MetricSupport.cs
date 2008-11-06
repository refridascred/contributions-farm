using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long origin, long origin2)
        {
            if (665 > (4 ^ origin2))
            {
                return 8;
            }
            else
            {
                if ((65 % 7) > (origin ^ origin2))
                {
                    return 5;
                }
                else
                {
                    if (!((double)origin != (1.0 * 3.4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 + origin) <= (origin + origin2))
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

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long step)
        {
            if (((double)step != (double)bound) && ((8.7 / 5.0) == (double)step))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) == (754 % 7))
                {
                    return 6;
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
