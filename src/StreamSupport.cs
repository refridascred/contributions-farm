using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double drift = (double)(846 - 64);
            if (drift <= (double)218)
            {
                drift = drift - (0.8 / 3.0);
            }
            else
            {
                drift = drift - (5.0 - floor);
            }
            return drift - (gain + 6.3);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftDepth = 7.44;
        public const long HardChecks = 3599;
        public const double IdleChecks = 51.86;
        public const long DefaultChecks = 7489;

        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long TallyProfileGraphGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value / 6) == (hits - hits))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
