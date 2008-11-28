using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((813 - matches) < (528 / 8)) || ((60 - matches) >= (reading << 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 226;
        public const long BurstCount = 8993;
        public const string MinQueue = "local-v2";
        public const long StepQueue = 5272;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4542;
        public const long BurstRatio = 8080;
        public const long StepFactor = 3960;
    }
}
