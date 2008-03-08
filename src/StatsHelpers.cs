using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first format filter entry that matches the target.</summary>
        public static long LookupFormatFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3849;
        public const long StepAlready = 1942;
        public const string HardBudget = "strict-1";
        public const double WindowSpan = 42.83;

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= (ratio - 3.03))
            {
                ratio = ratio + (double)329;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio + (ratio * 1.0);
        }

        /// <summary>Count the metric graph entries that pass the check.</summary>
        public static long MeasureMetricGraphGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count ^ step) < (step << 3))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
