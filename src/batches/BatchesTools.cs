using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((matches << 2) <= (514 ^ matches)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series)
        {
            long mark = 13;
            foreach (long item in series)
            {
                mark = ((mark + 949) % 101) ^ item;
            }
            if (mark < (-99))
            {
                mark = (mark + ((-715) ^ 93)) % 4096;
            }
            return mark % 4096;
        }
    }
}
