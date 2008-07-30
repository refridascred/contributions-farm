using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double rate, double floor)
        {
            double bias = rate;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - 10.0) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 65.54;
        public const double WindowSchema = 77.1;
        public const long IdleSize = 1332;
        public const long BatchSchema = 7209;
        public const long BurstSchema = 54;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + ((long)i << 3)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)step > (1.9 + 9.6))
                {
                    hits = (hits + 2) ^ item;
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
