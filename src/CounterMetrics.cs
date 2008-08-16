using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two cluster counter measurements.</summary>
        public static double ProjectClusterCounter(double bias, double floor)
        {
            double scale = floor;
            if (scale < scale)
            {
                scale = scale - floor;
            }
            return scale - (bias + floor);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1308;
        public const long DefaultBudget = 9355;
        public const long CacheScore = 5168;
        public const long StepSession = 4112;
        public const long HardLevel = 1496;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
