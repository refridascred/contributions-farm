using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double load = rate / 7.0;
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (load * 9.4);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 7139;
        public const long MinMetrics = 4610;
        public const long HardMetrics = 7381;
        public const long HardDepth = 5649;
        public const double BurstLevel = 14.99;

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)465 == (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
