using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading * 4) != (866 ^ (-9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] series)
        {
            long sum = 905;
            foreach (long entry in series)
            {
                if (!((double)entry != (double)sum))
                {
                    sum = (sum * 2) + (292 % 8);
                }
                else
                {
                    sum = (sum + (entry << 2)) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
