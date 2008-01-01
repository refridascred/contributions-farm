using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items, long origin)
        {
            long total = -7;
            foreach (long cell in items)
            {
                total = (((total ^ (total & 1)) % 97) ^ cell) - origin;
            }
            return total % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "fallback-edge";
        public const double MinLevel = 6.72;
        public const long BurstMetric = 1305;
        public const double DefaultMetric = 72.02;
        public const string LimitScore = "strict-v2";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result + result) ^ (long)i;
                    result = (result << 2) ^ (limit - 5);
                }
                if ((result + cell) >= (limit - cell))
                {
                    result = ((result * 4) + (result >> 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((64 / 9) >= (sample << 2)) && ((double)694 > 11.0)) && ((double)(-63) != (double)sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
