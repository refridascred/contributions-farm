using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryCount = 9515;
        public const long HardMetric = 3205;
        public const double BurstRatio = 91.31;
        public const long RetryMetric = 8676;
        public const long IdleMetric = 2395;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Locked,
            Draft,
            Done,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 22.08;
        public const long BurstTimeout = 4180;
        public const long BurstOrder = 8923;
    }
}
