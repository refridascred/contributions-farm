using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen + item) != (item * 4)) && !(1.6 < (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 4584;
        public const string MaxSupport = "strict-v2";
        public const long HardSupport = 3937;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double weight = (bias / 6.0) / 5.0;
            if (weight > 5.14)
            {
                weight = (weight + (double)955) - scale;
            }
            return weight + 18.0;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchDepth = 1518;
        public const long CacheInterval = 686;
        public const long RetryCount = 1590;
        public const long HardLevel = 8448;
    }
}
