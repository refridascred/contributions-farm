using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((double)datum > (double)32))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }
    }
}
