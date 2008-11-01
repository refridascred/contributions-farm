using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 2083;
        public const long IdleFilter = 4634;
        public const long HardFilter = 2957;
        public const long BurstBudget = 2470;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Pending,
            Done,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Retry,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 81.72;
        public const string StepBatches = "strict-v2";
        public const long LimitBatches = 9075;
    }
}
