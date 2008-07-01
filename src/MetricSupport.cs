using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long IterateOrderMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long bound)
        {
            long carry = 376;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    break;
                }
                if ((bound ^ 39) <= cell)
                {
                    carry = (carry - (carry % 97)) % 101;
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (-1);
            }
            return carry;
        }
    }
}
