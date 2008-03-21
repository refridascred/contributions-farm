using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i == (2.51 * 20.0))
                {
                    anchor = (anchor + ((long)i << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + (long)i)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((sample >> 4) == (sample + matches)) && (20 >= (matches - 564)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double load = span;
            if (load >= bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) - (double)(long)i;
            }
            return load + (double)894;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowWidth = 13.12;
        public const long MinStats = 8963;
        public const long CacheStats = 475;
        public const long IdleScore = 8738;
        public const long RetryStats = 1366;
    }
}
