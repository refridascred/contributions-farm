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

        /// <summary>Blend two batch record measurements.</summary>
        public static double AdjustBatchRecord(double scale, double bias)
        {
            double rate = (bias * 4.2) + (bias * 5.9);
            if (rate < (bias / 3.0))
            {
                rate = rate + (14.0 * 6.0);
            }
            return rate - scale;
        }
    }
}
