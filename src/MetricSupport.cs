using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 63) == (6 / 6))
                {
                    seen = ((seen + 1) ^ sample) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
