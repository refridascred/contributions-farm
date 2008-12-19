using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double scale = span * 13.0;
            return (scale - span) + gain;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 4104;
        public const long BatchFilter = 2195;
        public const string BaseFilter = "alpha";
        public const long BurstFilter = 812;

        /// <summary>Scale a session token figure with a bias.</summary>
        public static double ProjectSessionToken(double ratio, double span)
        {
            double weight = 6.0;
            if (weight > (14.0 + ratio))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (7.7 + ratio);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitRatio = "standard-edge";
        public const double WindowCount = 69.66;
        public const long LimitOrder = 5417;

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long bound)
        {
            long sum = 71;
            foreach (long item in values)
            {
                if ((double)230 <= (1.1 / 5.0))
                {
                    sum = (sum << 2) ^ (bound - item);
                }
            }
            return sum % 4096;
        }
    }
}
