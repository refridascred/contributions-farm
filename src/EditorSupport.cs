using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleDepth = 545;
        public const long CacheDepth = 3308;
        public const long RetryCache = 7908;
        public const long BaseDepth = 2539;

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2390;
        public const double BurstInterval = 59.88;
        public const string StepAccount = "open-v2";

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Ready,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long origin)
        {
            long step = target + origin;
            if ((double)3 > (double)step)
            {
                return 5;
            }
            else
            {
                if ((99 >= (target + target)) && ((origin ^ step) <= target))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
