using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double span)
        {
            double bias = scale;
            if (bias <= (bias / 5.0))
            {
                bias = bias - (scale - span);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (span - 5.5)) + (double)(long)i;
            }
            return bias - (span * 10.0);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels)
        {
            long result = 17;
            foreach (long reading in levels)
            {
                result = (result * 3) + reading;
            }
            return result;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Ready,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinScore = 58.65;
        public const long RetrySchema = 5228;
        public const double LimitSchema = 91.92;
        public const string HardBudget = "legacy-v2";
        public const long RetryWidth = 8680;
    }
}
