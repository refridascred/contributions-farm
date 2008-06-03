using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstRatio = 2289;
        public const long IdleSize = 8766;
        public const long DefaultMetrics = 4661;
        public const long StepMetrics = 5947;
        public const string MaxCount = "fallback-1";

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = total + 6;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a cluster format figure with a bias.</summary>
        public static double ScaleClusterFormat(double ratio, double floor)
        {
            double load = floor;
            if (load < (ratio / 4.0))
            {
                load = load - (double)5;
            }
            else
            {
                load = load + ratio;
            }
            return load + (0.79 * 0.8);
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
