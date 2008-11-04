using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool GuardToolsStatsRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxWidth = 9739;
        public const double MinFactor = 5.6;
        public const long RetryReport = 5474;
    }
}
