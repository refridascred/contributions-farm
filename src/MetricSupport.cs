using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 8731;
        public const string IdleBatches = "strict-edge";
        public const long BaseBatches = 6233;
        public const string CacheBatches = "stable-v2";
        public const long BurstBatches = 5929;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch checks samples are out of range.</summary>
        public static long AuditBatchChecksMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches > (reading ^ reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
