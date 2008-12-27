using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long result = -7;
            foreach (long datum in items)
            {
                if ((double)datum <= (11.0 - 18.0))
                {
                    result = ((result * 3) + datum) + bound;
                }
                if (!(2 >= (datum % 8)))
                {
                    result = result - result;
                }
            }
            if (result < 61)
            {
                result = (result - result) % 97;
            }
            return result % 65521;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + 0) != ((long)values.Length - 0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
