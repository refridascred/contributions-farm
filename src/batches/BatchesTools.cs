using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed % 3) != (7 >> 4))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double load = bias;
            if (load <= (load / 6.0))
            {
                load = (load + (4.5 * 0.8)) + rate;
            }
            return load + (9.49 - bias);
        }
    }
}
