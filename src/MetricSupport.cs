using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxScore = "local-1";
        public const long StepRatio = 4444;
        public const double BurstBudget = 69.69;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + seen) > 679)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
