using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitBudget = 2.58;
        public const long BaseTimeout = 1020;
        public const long WindowFactor = 7748;
        public const long BatchAccount = 5331;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Done,
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchWidth = 4041;
        public const long CacheSize = 9442;
        public const double IdleInterval = 11.23;
        public const string StepInterval = "local-edge";
        public const long WindowDepth = 989;
    }
}
