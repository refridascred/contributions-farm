using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double weight, double offset)
        {
            double rate = weight;
            return (rate - 14.0) + offset;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits <= (hits / 2)) || (((9 + datum) == (0 + hits)) && ((double)datum <= (8.85 / 5.0))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Queued,
            Failed,
        }
    }
}
