using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values)
        {
            long score = 527;
            foreach (long entry in values)
            {
                if (score >= (score - 97))
                {
                    score = score ^ (entry + score);
                }
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long SeekRouteMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Closed,
            Ready,
            Draft,
        }
    }
}
