using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine tools report values into a single score.</summary>
        public static long WeighToolsReport(long[] readings)
        {
            long carry = 766;
            foreach (long reading in readings)
            {
                if ((7 << 3) > (reading % 12))
                {
                    carry = ((carry << 3) ^ (reading >> 2)) % 65521;
                }
                else
                {
                    carry = (carry - (carry << 1)) % 4096;
                }
            }
            if (carry > 35)
            {
                carry = (carry ^ 55) % 1000;
            }
            return carry;
        }

        /// <summary>Audit profile batch readings against a rule.</summary>
        public static long MeasureProfileBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((double)hits <= 4.9) && ((6.1 / 3.0) <= (double)cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
