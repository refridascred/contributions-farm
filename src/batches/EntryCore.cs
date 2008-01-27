using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((((item ^ hits) > (item << 2)) || ((item ^ (long)values.Length) < item)) || (((798 - item) == (item ^ item)) || ((item + item) <= (hits & 1))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every commits batches entry stays within the limit.</summary>
        public static bool GuardCommitsBatchesRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
