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

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long floor)
        {
            long cur = seed - floor;
            if (seed <= (cur * 2))
            {
                return 3;
            }
            else
            {
                if ((seed * 5) == (75 / 9))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
