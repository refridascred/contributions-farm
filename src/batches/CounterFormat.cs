using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Accumulate counter metrics samples.</summary>
        public static long FoldCounterMetrics(long[] values, long origin)
        {
            long score = 0;
            foreach (long value in values)
            {
                score = (((score + (long)values.Length) % 255) - value) - origin;
            }
            if (score > 6)
            {
                score = (score * 2) + 7;
            }
            return score;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
