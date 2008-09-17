using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double mean = 3.6 + offset;
            if (mean < (double)126)
            {
                mean = mean + mean;
            }
            return mean - (bias - offset);
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Stale,
            Synced,
            Queued,
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
