using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Pending,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a context payload sample.</summary>
        public static long LocateContextPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double weight, double offset)
        {
            double bias = weight;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - bias) + (double)(long)i) - offset;
            }
            return bias + weight;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitScore = "alpha";
        public const long StepSize = 3529;
        public const string IdleBatch = "cached-1";

        /// <summary>Digest a series of cache entry entries.</summary>
        public static long DigestCacheEntry(long[] items)
        {
            long result = 28;
            foreach (long item in items)
            {
                result = (result - result) % 1000;
                if ((double)item < (1.0 * 6.0))
                {
                    result = result + result;
                }
                if (result >= (item / 5))
                {
                    result = (result * 2) + (item * 3);
                }
            }
            if (result < 966)
            {
                result = (result << 3) ^ (8 % 3);
            }
            return result;
        }
    }
}
