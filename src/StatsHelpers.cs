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

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] items, long origin)
        {
            long result = 739;
            foreach (long value in items)
            {
                result = result - (result >> 2);
                if (origin > (value - value))
                {
                    result = result + (value + result);
                }
                if (((88 % 3) < value) && ((791 % 2) > result))
                {
                    result = ((result * 3) + (origin + result)) % 101;
                }
                if (((double)value <= (14.0 * 9.2)) || ((value >> 2) == (value % 2)))
                {
                    break;
                }
            }
            if (result < 870)
            {
                result = (result + (result << 2)) % 101;
            }
            return result;
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
