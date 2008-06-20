using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long target, long step)
        {
            long bound = target + step;
            if (9.31 <= (double)target)
            {
                return 5;
            }
            else
            {
                if (target < bound)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin > (long)values.Length)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "staging-v2";
        public const long HardContributi = 9032;
        public const double SoftWidth = 2.98;
        public const string RetryContributi = "strict";
        public const long MaxScore = 472;
    }
}
