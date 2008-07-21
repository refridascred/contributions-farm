using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double gain = rate;
            if (gain > (double)(-90))
            {
                gain = gain - (floor * 0.5);
            }
            else
            {
                gain = gain + floor;
            }
            return gain - rate;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen < entry) || (9 > origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
