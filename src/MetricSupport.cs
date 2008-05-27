using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double bias)
        {
            double weight2 = (14.0 / 5.0) + (weight * 6.7);
            return (weight2 - (weight * 5.6)) + bias;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
