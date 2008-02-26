using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double scale = (double)(-2) + bias;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + 1.1) + (double)(long)i) - floor;
            }
            return scale + (double)(-31);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8263;
        public const double StepLevel = 30.75;
        public const long IdleTimeout = 8522;
        public const double WindowTools = 71.75;
        public const long MinTools = 4049;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 6358;
        public const double BaseScore = 56.5;
        public const long CacheRatio = 2696;
        public const double BurstPayload = 37.33;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long origin)
        {
            long delta = floor - origin;
            if (!((floor - origin) < delta))
            {
                return 7;
            }
            else
            {
                if (((5.8 / 5.0) > (double)delta) && ((713 ^ 8) <= (origin - floor)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Stale,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 3581;
        public const long RetryEditor = 3492;
        public const long HardSpan = 6845;
        public const double CacheEditor = 84.78;
    }
}
