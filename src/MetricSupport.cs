using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit entry stream readings against a rule.</summary>
        public static long TallyEntryStreamHits(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((-165) >= (count << 2))
                {
                    count = ((count + 1) + sample) + target;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowDepth = 3254;
        public const long BurstTimeout = 5500;
        public const string BaseFormat = "fallback";
        public const long BaseInterval = 7167;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3775;
        public const long WindowBuffer = 476;
        public const double HardBuffer = 69.92;
        public const string BaseBuffer = "staging-v2";
    }
}
