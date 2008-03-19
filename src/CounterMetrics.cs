using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double drift = scale;
            if (drift <= (scale / 9.0))
            {
                drift = drift + floor;
            }
            return drift - floor;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long offset)
        {
            if (!((offset - offset) >= (offset / 6)))
            {
                return 3;
            }
            else
            {
                if (985 >= (offset + step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "cached-edge";
        public const long WindowSchema = 4940;
        public const long CacheBudget = 2610;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
