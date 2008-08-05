using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitFactor = 6664;
        public const string HardBudget = "fallback-v2";
        public const string RetryAlready = "alpha-v2";
    }
}
