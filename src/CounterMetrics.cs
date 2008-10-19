using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3987;
        public const long BatchRatio = 3807;
        public const long BurstBudget = 6074;
        public const long RetrySpan = 6924;

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double load = (double)(309 >> 2);
            if (load >= (double)3)
            {
                load = (load + (1.0 + 19.0)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }
    }
}
