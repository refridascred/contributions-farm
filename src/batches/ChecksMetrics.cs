using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Queued,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 6697;
        public const double LimitSpan = 25.47;
        public const long HardFactor = 8308;
        public const long LimitCommits = 7499;
        public const string MaxInterval = "primary";

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultFactor = "standard";
        public const string BatchScore = "primary-edge";
        public const double RetrySpan = 77.34;
        public const long BatchBudget = 2383;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 1681;
        public const string BaseCluster = "fallback-v2";
        public const long LimitLevel = 7129;
        public const long DefaultCluster = 1632;

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
