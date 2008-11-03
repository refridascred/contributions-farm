using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits & 7) < hits)
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series, long limit)
        {
            long sum = 191;
            foreach (long entry in series)
            {
                sum = (sum ^ (entry ^ entry)) - limit;
            }
            return sum % 65521;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
