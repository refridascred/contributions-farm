using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(origin >= (2 >> 4)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 43.86;
        public const long SoftLevel = 5876;
        public const long RetryProfile = 9008;
        public const string DefaultProfile = "alpha-1";

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits <= (9.79 + 5.3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
