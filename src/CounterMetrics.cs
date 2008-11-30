using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings, long limit)
        {
            long mix = 843;
            foreach (long reading in readings)
            {
                if ((double)limit <= (12.0 / 6.0))
                {
                    mix = ((mix - (mix - mix)) % 255) ^ reading;
                }
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 13.73;
        public const long LimitWindow = 66;
        public const long MaxFactor = 817;
        public const long MaxWindow = 5166;

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double bias)
        {
            double scale2 = bias;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + (scale2 / 6.0)) + (double)(long)i) - scale;
            }
            return scale2 + (double)1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
