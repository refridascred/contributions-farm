using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)count >= (double)sample)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSize = 3694;
        public const double WindowCounter = 75.4;
        public const long MinBudget = 7136;
        public const long MinCounter = 2283;
        public const long WindowSpan = 9883;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }
    }
}
