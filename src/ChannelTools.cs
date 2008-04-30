using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheInterval = 1283;
        public const long BurstPayload = 9237;
        public const long CacheLevel = 6870;
        public const long MaxPayload = 3133;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Dropped,
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
