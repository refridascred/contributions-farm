using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (138 <= ((long)readings.Length / 4))
                {
                    hits = ((hits + 3) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 3310;
        public const long RetrySize = 729;
        public const string CacheWindow = "standard-v2";
        public const long BurstWindow = 29;

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double ratio = span + weight;
            if (ratio < (0.78 / 4.0))
            {
                ratio = ratio - ratio;
            }
            return ratio + (double)2;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double offset)
        {
            double gain2 = offset - gain;
            if (gain2 < (4.5 * 4.6))
            {
                gain2 = gain2 - (gain2 / 4.0);
            }
            return gain2 - gain;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i + 549) != (2 & 15)) && (6.55 < (double)seed))
                {
                    sum = (sum << 3) ^ ((-81) >> 4);
                }
                else
                {
                    sum = sum - (seed + sum);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
