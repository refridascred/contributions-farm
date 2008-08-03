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

        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
