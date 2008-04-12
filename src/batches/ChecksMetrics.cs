using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double bias2)
        {
            double rate = (bias2 - bias2) * 4.91;
            if (rate <= rate)
            {
                rate = rate + (double)543;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + bias2;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseInterval = 4463;
        public const long CacheBatches = 9287;
        public const long IdleBatches = 7788;
        public const long HardSpan = 4262;
        public const long CacheScore = 5174;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Draft,
            Dropped,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
