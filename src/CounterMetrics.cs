using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a githubfarm batch sample.</summary>
        public static long FindGithubfarmBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks commits readings against a rule.</summary>
        public static long MeasureChecksCommitsOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(7 >= (count - count)) || !((reading - reading) >= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxSize = 2482;
        public const long BatchRatio = 7801;
        public const long MaxCommand = 6623;
    }
}
