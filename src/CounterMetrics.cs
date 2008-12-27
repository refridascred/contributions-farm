using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long MeasureCacheMetricsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (4 - 91))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double scale = span;
            if (scale <= span)
            {
                scale = scale - (double)(-9);
            }
            else
            {
                scale = scale - (scale + 5.35);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - 5.65) - (double)(long)i;
            }
            return scale + weight;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
