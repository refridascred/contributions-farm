using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every batch schema entry stays within the limit.</summary>
        public static bool ValidateBatchSchemaRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long AuditRouteMetricOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - step) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
