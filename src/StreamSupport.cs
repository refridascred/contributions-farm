using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 <= 4.33)
            {
                weight2 = weight2 - weight;
            }
            else
            {
                weight2 = weight2 + (weight2 / 5.0);
            }
            return weight2 + (double)592;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryTimeout = 4973;
        public const long DefaultFactor = 9702;
        public const long HardDepth = 2673;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits <= sample) || !(hits < sample))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
