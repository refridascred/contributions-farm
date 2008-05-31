using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 3519;
        public const string RetryReport = "alpha-v2";
        public const long LimitScore = 4951;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Failed,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitWidth = "open-1";
        public const long HardDepth = 5308;
        public const long BaseBuffer = 4889;
        public const string BaseWidth = "strict";
    }
}
