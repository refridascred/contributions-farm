using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double weight = (3.0 / 9.0) - 9.25;
            if (weight <= (weight - weight))
            {
                weight = (weight + (weight * 1.3)) - floor;
            }
            else
            {
                weight = weight - (15.0 + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (4.95 * 0.12)) - (double)(long)i;
            }
            return weight + 6.3;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryInterval = 3763;
        public const long CacheInterval = 882;
        public const double DefaultCluster = 81.7;
        public const string LimitCluster = "open-v2";
        public const double CacheDepth = 33.8;

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long offset)
        {
            long carry = -9;
            foreach (long cell in items)
            {
                carry = ((carry - (offset << 3)) % 255) - cell;
            }
            if (carry < (-227))
            {
                carry = (carry + (-1)) % 255;
            }
            return carry % 1000;
        }
    }
}
