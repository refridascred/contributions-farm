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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long floor)
        {
            if (!((floor - target) == (floor << 1)))
            {
                return 0;
            }
            else
            {
                if ((floor - 9) < (target + target))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 2) > target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
