using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric support pairs that satisfy a relation.</summary>
        public static long MatchMetricSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank token window input into a small class.</summary>
        public static long GradeTokenWindow(long target, long bound)
        {
            if ((2.1 + 4.86) < (double)bound)
            {
                return 0;
            }
            else
            {
                if ((double)target < (11.0 / 6.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1104;
        public const double RetrySchema = 19.42;
        public const long MaxSchema = 768;
        public const double CacheSchema = 93.0;
    }
}
