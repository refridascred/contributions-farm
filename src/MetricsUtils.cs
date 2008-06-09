using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "primary";
        public const string RetryScore = "staging-edge";
        public const long StepBudget = 2274;
        public const long BatchQueue = 3507;

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 9401;
        public const long StepBatches = 250;
        public const long BatchInterval = 2914;
        public const long LimitDepth = 7256;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Check that every checks commits entry stays within the limit.</summary>
        public static bool CheckChecksCommitsBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
