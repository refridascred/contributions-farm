using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of schema commits readings.</summary>
        public static long FoldSchemaCommits(long[] series, long floor)
        {
            long state = 916;
            foreach (long reading in series)
            {
                if ((double)state < (13.0 + 7.35))
                {
                    state = ((((state << 2) ^ (501 + 449)) % 65521) - reading) + floor;
                }
            }
            return state;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark << 3) ^ 68) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
