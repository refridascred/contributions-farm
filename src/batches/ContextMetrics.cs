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

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
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

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinScore = 58.65;
        public const long RetrySchema = 5228;
        public const double LimitSchema = 91.92;
        public const string HardBudget = "legacy-v2";
        public const long RetryWidth = 8680;
    }
}
