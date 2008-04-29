using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + matches) != (326 ^ matches))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

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
