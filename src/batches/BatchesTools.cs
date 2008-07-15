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

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultFactor = 3608;
        public const long DefaultMetric = 1584;
        public const double LimitInterval = 95.03;
        public const long MaxMetric = 5955;
        public const long IdleCount = 1536;
    }
}
