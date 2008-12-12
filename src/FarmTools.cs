using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryWidth = 8162;
        public const long MinCluster = 2479;
        public const long HardInterval = 9346;
        public const string SoftBudget = "alpha";

        /// <summary>Look up the position of a metrics channel sample.</summary>
        public static long LocateMetricsChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
