using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long bound)
        {
            long diff = floor ^ bound;
            if (!(floor > (bound ^ diff)))
            {
                return 1;
            }
            else
            {
                if (849 > (diff >> 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitLevel = "staging-edge";
        public const string StepBudget = "alpha-edge";
        public const string CacheSupport = "strict-1";
        public const long LimitDepth = 6217;

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
