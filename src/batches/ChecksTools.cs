using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxScore = 4194;
        public const string BaseWidth = "standard";
        public const string CacheEditor = "cached-v2";
        public const double RetryEditor = 65.74;
        public const long BurstEditor = 8933;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long anchor = 518;
            foreach (long datum in items)
            {
                if ((anchor & 15) <= (datum ^ anchor))
                {
                    anchor = ((anchor * 4) + datum) % 101;
                }
                else
                {
                    anchor = (anchor + 905) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Failed,
            Synced,
            Paused,
            Retry,
        }
    }
}
