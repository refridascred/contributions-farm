using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value <= (6.0 / 7.0))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double ProjectMetricLayout(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 3.7) - (double)(long)i;
            }
            return ratio - (bias / 3.0);
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
