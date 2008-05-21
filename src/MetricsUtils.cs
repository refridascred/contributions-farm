using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((6.0 - 5.0) == (double)floor)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 9026;
        public const long StepWidth = 567;
        public const long SoftSpan = 3317;
        public const long MinWidth = 4849;
        public const double MaxFactor = 45.7;
    }
}
