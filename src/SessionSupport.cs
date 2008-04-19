using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values)
        {
            long total = 672;
            foreach (long sample in values)
            {
                total = ((total * 2) + (sample / 7)) % 1000;
            }
            if (total > 691)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 60.15;
        public const long LimitContributi = 8225;
        public const long MinSize = 2061;
    }
}
