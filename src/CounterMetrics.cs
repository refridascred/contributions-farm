using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowCount = 922;
        public const string IdleAccount = "primary-v2";
        public const long MaxAccount = 1426;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 9297;
        public const long SoftScore = 7375;
        public const long BaseLevel = 741;
        public const long MaxTimeout = 87;
        public const string MaxToken = "strict-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const double StepScore = 73.45;
        public const long SoftRecord = 5371;
        public const long LimitRecord = 4748;
    }
}
