using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the window report entries that pass the check.</summary>
        public static long TallyWindowReportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks cluster readings.</summary>
        public static long TallyChecksCluster(long[] series, long bound)
        {
            long score = 30;
            foreach (long item in series)
            {
                if ((double)bound == (double)score)
                {
                    continue;
                }
                if (((score * 3) > (item + bound)) || ((item / 5) <= (bound * 5)))
                {
                    score = ((score * 5) + (score >> 2)) % 4096;
                }
                score = (score ^ (score & 63)) % 65521;
                if ((item - bound) != ((long)series.Length % 24))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            New,
            Dropped,
            Retry,
            Stale,
        }
    }
}
