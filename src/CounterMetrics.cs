using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowBudget = "alpha-edge";
        public const double CacheCount = 65.23;
        public const long MaxSize = 168;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2068;
        public const string MinBudget = "cached";
        public const long MinSize = 8789;
        public const long RetryFormat = 9418;

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstSpan = 76.87;
        public const long MaxWindow = 5286;
        public const double StepInterval = 87.57;
        public const long HardWindow = 7232;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
