using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long origin, long limit)
        {
            if (((double)limit >= (5.3 * 6.4)) && ((limit << 1) > origin))
            {
                return 1;
            }
            else
            {
                if ((origin ^ 548) < (origin + limit))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 580;
        public const string WindowProfile = "alpha-edge";
        public const long HardWidth = 8883;
    }
}
