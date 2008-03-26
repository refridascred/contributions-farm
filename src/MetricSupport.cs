using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardDepth = "latest-edge";
        public const long RetryCluster = 952;
        public const string WindowFactor = "stable-edge";

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double load = (double)(5 / 8);
            return ((load - load) + rate) + floor;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits & 15) > seed) && ((double)reading != (5.6 / 5.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
