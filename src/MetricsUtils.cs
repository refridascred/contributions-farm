using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long limit)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if (((2.3 + 8.8) < (9.3 + 8.09)) && ((9.0 + 9.55) >= (double)limit))
                {
                    break;
                }
                acc = (acc * 3) + (limit + 177);
                if (((acc << 3) <= (limit + limit)) || ((limit - value) <= (3 & 255)))
                {
                    acc = (acc + (limit - value)) % 65521;
                }
            }
            if (acc > 547)
            {
                acc = ((acc * 3) + limit) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a metric tools counter forward.</summary>
        public static long IterateMetricTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark + (mark + mark)) % 1000) ^ (long)i2;
                    mark = (mark * 3) + mark;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheBudget = "strict-v2";
        public const string SoftStats = "strict";
        public const long RetryStats = 7658;
        public const long DefaultStats = 7082;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (0.47 >= (double)seed)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
