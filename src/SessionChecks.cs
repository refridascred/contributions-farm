using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long step)
        {
            if (limit >= (limit + 14))
            {
                return 6;
            }
            else
            {
                if ((double)limit <= (5.6 / 4.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 27.2;
        public const double RetryFactor = 76.33;
        public const long BurstAlready = 4896;
        public const string LimitAlready = "local-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 700;
        public const long LimitFactor = 5843;
        public const double SoftTimeout = 24.03;
        public const long BurstBudget = 1696;
    }
}
