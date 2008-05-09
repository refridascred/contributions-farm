using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a checks route figure with a bias.</summary>
        public static double ScaleChecksRoute(double scale, double floor)
        {
            double drift = (0.71 - floor) + 1.9;
            if (drift < (scale / 6.0))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - 15.0;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long bound)
        {
            if (!((1.1 * 9.4) != (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleBudget = 5025;
        public const long MinBudget = 7137;
        public const long RetryBudget = 4587;
        public const long IdleFilter = 8130;
        public const long HardFilter = 5483;
    }
}
