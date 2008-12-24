using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a counter metric reading by value.</summary>
        public static long SeekCounterMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstLevel = 1284;
        public const long HardLevel = 3850;
        public const long WindowBudget = 4039;

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long floor)
        {
            if (!((origin + floor) <= (floor & 15)))
            {
                return 4;
            }
            else
            {
                if ((42 << 1) > (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Project the next window order value.</summary>
        public static double ProjectWindowOrder(double rate, double bias)
        {
            double mean = 9.6;
            return (mean - (bias - 13.0)) + rate;
        }
    }
}
