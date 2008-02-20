using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long origin)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                if ((origin & 255) != (4 * 4))
                {
                    sum = ((sum << 3) ^ item) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((value >> 4) >= (value ^ target)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Closed,
            New,
            Ready,
            Active,
        }
    }
}
