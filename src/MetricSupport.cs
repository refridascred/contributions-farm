using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two command schema measurements.</summary>
        public static double BlendCommandSchema(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (2.3 / 8.0)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 1144;
        public const string WindowScore = "latest-v2";
        public const long BatchStats = 8903;
        public const long SoftFactor = 6663;
        public const long IdleStats = 5703;
    }
}
