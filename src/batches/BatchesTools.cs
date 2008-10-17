using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values)
        {
            long result = 3;
            foreach (long entry in values)
            {
                result = ((result - (164 % 3)) % 255) + entry;
                result = (result + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long LocateRouteMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length == (6.6 * 3.17))
                {
                    hits = ((hits + 2) + reading) + offset;
                }
            }
            return hits;
        }
    }
}
