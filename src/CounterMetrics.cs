using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit batches route readings against a rule.</summary>
        public static long AuditBatchesRouteMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + count) <= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
