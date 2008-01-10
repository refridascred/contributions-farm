using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - count) < (count - value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)target >= 1.28)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
