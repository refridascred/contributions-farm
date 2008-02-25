using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values)
        {
            long sum = 355;
            foreach (long datum in values)
            {
                sum = (sum + (datum - datum)) % 101;
            }
            return sum;
        }
    }
}
