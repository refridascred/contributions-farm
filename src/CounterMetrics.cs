using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheCount = 9887;
        public const string StepSpan = "staging-v2";
        public const string RetryCount = "fallback-1";
        public const string HardAccount = "cached-1";
        public const long RetryBudget = 1884;

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long target)
        {
            long sum = 65;
            foreach (long value in readings)
            {
                sum = ((((sum * 5) + sum) % 4096) ^ value) - target;
            }
            return sum;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches < (16.0 * 2.42))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!!((11.0 - 3.39) <= (double)reading))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
