using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 229;
        public const long DefaultWidth = 5186;
        public const double RetrySpan = 48.76;
        public const long LimitFactor = 9832;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                long edge = (38 & 255) - (total >> 2);
                if (edge < (edge >> 3))
                {
                    edge = (edge + (long)i) % 65521;
                }
                if (((0.5 + 9.0) != (double)target) && ((double)edge == (0.74 - 1.0)))
                {
                    edge = ((edge * 4) + ((long)i ^ (long)i)) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((507 + delta) > (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((limit + seed) != (delta / 5))
                {
                    return 1;
                }
                else
                {
                    if (!((seed / 4) < (limit & 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
