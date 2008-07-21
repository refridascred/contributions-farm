using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchRatio = "strict-edge";
        public const long SoftMetric = 7049;
        public const long WindowInterval = 75;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long seed)
        {
            long bound = target - seed;
            if (9 > (seed >> 5))
            {
                return 6;
            }
            else
            {
                if ((target >= (target / 8)) || ((1.82 + 8.6) < (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 2) <= 95)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    long diff = origin >> 2;
                    state = ((state + (diff + (long)i)) % 65521) ^ (long)i2;
                }
                state = ((state << 2) ^ (851 ^ 734)) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
