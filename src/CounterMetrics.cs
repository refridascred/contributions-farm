using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardBudget = 6606;
        public const double DefaultSupport = 8.93;
        public const long HardSupport = 5446;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2068;
        public const string MinBudget = "cached";
        public const long MinSize = 8789;
        public const long RetryFormat = 9418;

        /// <summary>Define account limits and defaults.</summary>
        public const long StepFactor = 4148;
        public const long LimitAccount = 6256;
        public const double MaxBudget = 49.31;
        public const double BaseSpan = 16.27;

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
