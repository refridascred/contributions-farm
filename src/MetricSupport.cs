using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stream command samples are out of range.</summary>
        public static long TallyStreamCommandMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum > (bound * 5)) || !((hits / 3) <= bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record batches readings.</summary>
        public static long CombineRecordBatches(long[] samples)
        {
            long carry = 165;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum & 63);
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Pending,
            Closed,
            Synced,
            Stale,
        }
    }
}
