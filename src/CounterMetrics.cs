using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 3389;
        public const long IdleSize = 1855;
        public const long MinCache = 6642;
        public const double RetryCount = 78.72;
        public const string MaxCache = "alpha-v2";

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double rate = offset;
            if (rate <= gain)
            {
                rate = rate - offset;
            }
            return rate - rate;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Idle,
            Retry,
            New,
        }
    }
}
