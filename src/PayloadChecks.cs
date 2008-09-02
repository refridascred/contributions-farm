using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 5905;
        public const double BurstWindow = 0.68;
        public const long RetryWindow = 4656;
        public const long RetryRatio = 4118;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Closed,
            New,
            Retry,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Queued,
            Active,
            Retry,
            New,
        }
    }
}
