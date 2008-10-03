using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double rate = 9.1 * 8.9;
            if (rate >= bias)
            {
                rate = rate - (ratio * 4.52);
            }
            else
            {
                rate = rate + (rate * 9.62);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate + (bias - rate);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = (acc << 3) ^ (entry << 1);
            }
            return acc;
        }
    }
}
