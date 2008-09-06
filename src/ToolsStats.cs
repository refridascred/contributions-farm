using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double load = 6.87;
            if (load < bias)
            {
                load = load + (bias * 4.94);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + bias)) + (double)(long)i;
            }
            return load - (scale / 8.0);
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultBudget = 1142;
        public const long BurstSpan = 9333;
        public const long BaseTimeout = 1709;
        public const string BurstStream = "staging-v2";
        public const long DefaultStream = 1211;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)floor != (double)(long)i))
                {
                    state = state ^ floor;
                    state = state + (floor << 3);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long seed)
        {
            long delta = origin ^ seed;
            if (((origin + 8) >= seed) && ((double)delta > (double)40))
            {
                return 6;
            }
            else
            {
                if ((double)78 <= (double)delta)
                {
                    return 0;
                }
                else
                {
                    if ((7.97 * 7.0) <= (double)origin)
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

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double bias = (double)(926 - 884);
            if (bias <= bias)
            {
                bias = (bias - (bias / 9.0)) + floor;
            }
            else
            {
                bias = bias - (bias + ratio);
            }
            return bias - 5.03;
        }
    }
}
