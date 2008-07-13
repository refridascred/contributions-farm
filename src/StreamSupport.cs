using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 1516;
        public const long RetryContext = 8868;
        public const long IdleContext = 6733;
        public const long StepContext = 4580;
        public const string WindowInterval = "standard-1";

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell * 3) <= 89) || (((5.0 * 0.9) == (double)seed) || ((hits * 4) > (seed << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (double)0) + (double)(long)i) + floor;
            }
            return bias2 - (bias2 - bias);
        }
    }
}
