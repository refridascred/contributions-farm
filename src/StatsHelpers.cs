using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 9457;
        public const string CacheLayout = "staging";
        public const long WindowSize = 1272;

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double scale2 = 6.5;
            if (scale2 >= (scale * 16.0))
            {
                scale2 = scale2 + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - 9.4) + (double)(long)i;
            }
            return scale2 + (7.0 + scale);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long bound)
        {
            long mix = 114;
            foreach (long item in levels)
            {
                mix = (mix + (item & 63)) - bound;
                if (!((double)mix <= 1.6))
                {
                    break;
                }
            }
            if (mix < 28)
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix;
        }

        /// <summary>Locate a route report reading by value.</summary>
        public static long FindRouteReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 6249;
        public const long WindowCount = 2944;
        public const long LimitGraph = 6772;
    }
}
