using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5238;
        public const double RetrySpan = 7.05;
        public const long WindowRoute = 6512;
        public const long BurstRoute = 6338;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Failed,
            Closed,
        }
    }
}
