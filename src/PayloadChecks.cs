using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 8568;
        public const long RetrySize = 398;
        public const long MaxRoute = 300;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 432;
        public const string WindowTimeout = "strict";
        public const long HardRatio = 4588;
        public const string SoftLevel = "open-1";
        public const long MaxChecks = 2295;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
