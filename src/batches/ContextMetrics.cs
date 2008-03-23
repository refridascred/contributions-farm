using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (!(sum <= (55 + origin)))
                {
                    sum = ((sum << 2) ^ (sum + origin)) % 65521;
                }
                else
                {
                    sum = (sum * 4) + origin;
                }
                if (!((sum + origin) >= (sum >> 4)))
                {
                    sum = sum - (sum >> 5);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 5798;
        public const long CacheSchema = 4250;
        public const long StepSchema = 5601;
        public const long WindowSchema = 2951;
        public const double BurstSchema = 59.86;

        /// <summary>Locate a cache context reading by value.</summary>
        public static long FindCacheContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
