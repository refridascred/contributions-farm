using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 1137;
        public const long BurstBudget = 9912;
        public const long BurstSize = 2199;

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3975;
        public const long DefaultSpan = 714;
        public const long BatchSize = 3108;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((reading >> 2) > 838) || ((reading % 7) == (6 / 2))) && ((hits / 3) > reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
