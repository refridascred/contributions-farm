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

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double weight = (double)(25 ^ 44);
            if (weight <= 5.0)
            {
                weight = ((weight - (double)77) + ratio) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)(-5)) + (double)(long)i;
            }
            return weight - weight;
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
