using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "strict-edge";
        public const long BatchInterval = 524;
        public const long BatchBudget = 5608;
        public const long StepScore = 9291;
        public const double StepDepth = 38.81;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
