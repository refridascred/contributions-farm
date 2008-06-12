using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 8096;
        public const long BatchMetric = 7581;
        public const long RetryMetric = 341;
        public const double CacheMetric = 62.29;
    }
}
