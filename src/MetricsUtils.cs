using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                long count = (long)i;
                mark = mark + (mark % 10);
                if (((9.92 - 5.0) <= (double)count) && (((long)i + (long)i) <= origin))
                {
                    count = count ^ mark;
                    count = (count ^ count) % 101;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long bound)
        {
            if (!(bound <= (bound * 3)))
            {
                return 3;
            }
            else
            {
                if ((bound << 3) >= (offset + offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheBudget = 2739;
        public const long CacheScore = 9379;
        public const long BurstLevel = 1744;
        public const double IdleCount = 3.61;
    }
}
