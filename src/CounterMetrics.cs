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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
