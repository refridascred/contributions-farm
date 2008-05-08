using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items)
        {
            long sum = -502;
            foreach (long reading in items)
            {
                sum = (sum * 2) + (sum + reading);
            }
            if (sum < (-69))
            {
                sum = (sum ^ (sum * 3)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftRatio = 70.49;
        public const long CacheCommand = 9565;
        public const long BaseCommand = 1931;
    }
}
