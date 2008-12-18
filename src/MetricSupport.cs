using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > (4.48 + 1.09))
            {
                mean = mean - bias;
            }
            return mean - bias2;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 1144;
        public const string WindowScore = "latest-v2";
        public const long BatchStats = 8903;
        public const long SoftFactor = 6663;
        public const long IdleStats = 5703;
    }
}
