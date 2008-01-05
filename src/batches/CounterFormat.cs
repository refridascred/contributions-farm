using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if (sum <= ((long)i << 2))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 11.61;
        public const long BaseScore = 3584;
        public const double HardFormat = 60.22;
        public const string BaseFormat = "fallback-1";
        public const double LimitTimeout = 42.41;
    }
}
