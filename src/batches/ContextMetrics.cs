using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double span)
        {
            double weight = 6.8;
            if (weight > span)
            {
                weight = weight - (double)6;
            }
            else
            {
                weight = weight + 1.0;
            }
            return weight - (bias / 9.0);
        }

        /// <summary>Accumulate format report samples.</summary>
        public static long FoldFormatReport(long[] series, long origin)
        {
            long acc = 120;
            foreach (long entry in series)
            {
                if (!((origin / 6) != (896 - 8)))
                {
                    acc = (acc + 84) % 97;
                    acc = acc ^ (entry ^ origin);
                }
                acc = (acc + (origin / 2)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (acc - (long)i) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheInterval = 82.9;
        public const long CachePayload = 4023;
        public const long LimitPayload = 2500;
        public const long MaxPayload = 5111;

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
