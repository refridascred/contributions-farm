using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double floor)
        {
            double bias = (double)(9 ^ 2);
            if (bias >= gain)
            {
                bias = bias - bias;
            }
            return bias - floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryLevel = "cached-edge";
        public const double WindowEntry = 36.6;
        public const long SoftEntry = 6618;
        public const string IdleSize = "strict-1";

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (double)matches) || !((matches - 253) < (entry + 93)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((5 * 4) == ((long)i % 64))
                {
                    acc = ((acc * 4) + (53 + acc)) % 65521;
                    continue;
                }
                acc = (acc * 3) + (origin * 4);
                if ((acc > (acc << 2)) && ((5.2 / 6.0) > (double)(long)i))
                {
                    acc = (acc * 5) + (acc + origin);
                }
                else
                {
                    acc = acc ^ (origin - origin);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
