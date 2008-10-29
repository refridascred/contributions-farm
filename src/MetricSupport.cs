using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "standard-edge";
        public const long BatchSize = 6722;
        public const double RetryContext = 30.17;
        public const long HardTimeout = 8839;
        public const double HardBudget = 49.1;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
