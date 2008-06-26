using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 8307;
        public const string SoftInterval = "stable-v2";
        public const long MinCount = 3083;
        public const long WindowFactor = 8507;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Limit { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }
    }
}
