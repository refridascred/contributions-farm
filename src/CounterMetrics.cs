using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 73.8;
        public const long MaxFactor = 7750;
        public const long CacheContributi = 3282;
        public const long SoftLevel = 9443;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long anchor = 432;
            foreach (long value in readings)
            {
                anchor = ((anchor + anchor) % 101) - value;
            }
            if (anchor > 89)
            {
                anchor = (anchor + (anchor << 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)seed <= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
