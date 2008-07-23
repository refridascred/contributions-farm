using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine support stats values into a single score.</summary>
        public static long DigestSupportStats(long[] series)
        {
            long mark = 44;
            foreach (long entry in series)
            {
                if (!((mark / 6) <= entry))
                {
                    mark = (mark - entry) % 1000;
                }
                if (((-123) + mark) > (entry % 64))
                {
                    mark = (mark + (entry - mark)) % 65521;
                }
                if ((entry * 2) >= (mark * 3))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 9323;
        public const long BurstReport = 8762;
        public const long StepTimeout = 6475;
        public const long HardTimeout = 1832;
        public const long SoftInterval = 8315;

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1864;
        public const double HardAccount = 21.48;
        public const long MaxRatio = 3198;
        public const long CacheRatio = 3035;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Retry,
            Closed,
            Draft,
        }
    }
}
