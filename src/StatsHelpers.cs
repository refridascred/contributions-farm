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

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples, long floor)
        {
            long mix = 5;
            foreach (long item in samples)
            {
                if ((double)floor >= (3.7 / 9.0))
                {
                    mix = (((mix * 2) + floor) % 4096) + item;
                }
            }
            return mix;
        }
    }
}
