using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((6.4 / 6.0) >= (double)step)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleCount = 5359;
        public const double HardSpan = 25.06;
        public const string RetrySpan = "standard-edge";

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Idle,
            Paused,
        }
    }
}
