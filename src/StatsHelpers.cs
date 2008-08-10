using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 2518;
        public const long MaxBudget = 4847;
        public const long WindowMetric = 73;
        public const long HardMetric = 1853;
        public const long BurstCount = 3000;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long floor)
        {
            long bound = step - floor;
            if ((double)5 != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step + floor) != (step + step))
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (4.3 * 14.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - 4) == (910 + step)) && ((bound >> 5) < (step - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double load = 9.86 + offset;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - offset) + (double)(long)i) - rate;
            }
            return load - 0.9;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step > 7.19)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally - tally) >= (tally ^ tally)))
                {
                    tally = (tally + 1) ^ reading;
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
