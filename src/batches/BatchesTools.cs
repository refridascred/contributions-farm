using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Synced,
            Pending,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum * 3) != (datum + datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length - (-172)) >= (tally % 64))
                {
                    tally = ((tally + 3) + reading) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
