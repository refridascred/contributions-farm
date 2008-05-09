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

        /// <summary>Look up the position of a metrics tools sample.</summary>
        public static long FindMetricsToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleBudget = 5025;
        public const long MinBudget = 7137;
        public const long RetryBudget = 4587;
        public const long IdleFilter = 8130;
        public const long HardFilter = 5483;
    }
}
