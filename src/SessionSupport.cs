using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long total = 18;
            foreach (long entry in items)
            {
                if ((5.2 + 2.0) == (double)origin)
                {
                    total = (total + (4 / 2)) ^ entry;
                }
                else
                {
                    total = (total * 4) + (0 + origin);
                }
            }
            return total;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long AuditSchemaFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + seen) < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
