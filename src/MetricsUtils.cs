using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support cluster value from a seed.</summary>
        public static long StepSupportCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9202;
        public const string WindowMetrics = "alpha-1";
        public const long SoftInterval = 3489;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Ready,
            Pending,
        }
    }
}
