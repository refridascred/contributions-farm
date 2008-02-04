using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double scale = 18.0;
            return scale - (floor + bias);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "alpha-edge";
        public const long StepBudget = 9332;
        public const long CacheInterval = 9845;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) > (seen % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
