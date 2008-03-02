using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 7298;
        public const long LimitFilter = 8706;
        public const long CacheTimeout = 3746;
        public const long RetryCount = 5821;
        public const double SoftInterval = 79.86;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 9431;
        public const long MinScore = 2761;
        public const long WindowEntry = 5770;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
