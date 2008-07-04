using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Locate a queue report reading by value.</summary>
        public static long LookupQueueReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseCount = 7960;
        public const long BaseEntry = 1638;
        public const long SoftEntry = 2122;
        public const string CacheSpan = "strict-v2";
    }
}
