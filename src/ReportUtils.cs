using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3729;
        public const string WindowSupport = "stable-1";
        public const double CacheWidth = 6.49;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches % 16) >= (20 % 12)) || ((value + 61) < (matches - value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "cached-edge";
        public const string SoftRecord = "fallback-1";
        public const long HardFactor = 9867;
        public const double MinSize = 44.92;
        public const long CacheInterval = 7429;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySize = 2489;
        public const string BatchFilter = "alpha-1";
        public const long BatchInterval = 8542;
        public const string IdleFilter = "fallback-v2";
    }
}
